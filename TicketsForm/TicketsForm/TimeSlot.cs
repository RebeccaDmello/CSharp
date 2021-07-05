using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsForm
{
    public class TimeSlot
    {
        public DateTime beginSlot, endSlot;
        public int slotLength, ticketIssued;
        public TimeSlot(DateTime beginSlot, int slotLength, int ticketIssued)
        {
            this.beginSlot = beginSlot;
            this.slotLength = slotLength;
            this.ticketIssued = ticketIssued;
        }
        public DateTime EndSlot
        {
            get
            {
                return endSlot;
            }
            set
            {
                endSlot = value;
            }
        }
        public int SlotLength
        {
            get
            {
                return slotLength;
            }
            set
            {
                slotLength = value;
            }
        }
        public int TicketIssued
        {
            get
            {
                return ticketIssued;
            }
            set
            {
                ticketIssued = value;
            }
        }
        public DateTime BeginSlot
        {
            get
            {
                return beginSlot;
            }
            set
            {
                beginSlot = value;
            }
        }
    }
}
