using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        //public InvItem GetItemByIndex(int i) => invItems[i];//Modified by Rebecca
        // int type indexer
        public InvItem this[int index]
        {
            get
            {
                if (index < 0 || index >= invItems.Count)
                    throw new ArgumentOutOfRangeException("Index "+index+" is out of range");

                return invItems[index];
            }

            set
            {
                invItems[index] = value;
            }
        }

        public void Add(InvItem invItem) => invItems.Add(invItem);

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
        }

        public void Remove(InvItem invItem) => invItems.Remove(invItem);

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);

        // Overload + operator to add InvItem to list. //Added by Rebecca
        public static InvItemList operator+ (InvItemList invItemList, InvItem invItem)
        {
            invItemList.Add(invItem);
            return invItemList;
        }

        // Overload - operator to add InvItem to list. //Added by Rebecca
        public static InvItemList operator- (InvItemList invItemList, InvItem invItem)
        {
            invItemList.Remove(invItem);
            return invItemList;
        }


        //Delegate //Added by Rebecca
        public delegate void ChangeHandler(InvItemList invItemList);


        // event //Added by Rebecca
        public event ChangeHandler Changed;

        //Added by Rebecca
        public void StartProcess(InvItemList invItemList)
        {
            //MessageBox.Show("Invoked!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            OnChanged(invItemList);
        }

        //Added by Rebecca
        protected virtual void OnChanged(InvItemList invItemList)
        {
            //if ProcessCompleted is not null then call delegate
            Changed?.Invoke(invItemList);
        }
    }
}
