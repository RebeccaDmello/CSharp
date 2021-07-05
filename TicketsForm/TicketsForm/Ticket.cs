using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsForm
{
    public class Ticket
    {
        public int ticketNumber, nextTicketNumber;
        public DateTime timeSlot;

        public Ticket (int ticketNumber, DateTime timeSlot)
        {
            this.ticketNumber = ticketNumber;
            this.timeSlot = timeSlot;
            
            Console.WriteLine("Ticket " + ticketNumber + ": " + timeSlot.ToString("h:mm tt"));
        }

        public int TicketNumber
        {
            get
            {
                return ticketNumber;
            }
            set
            {
                ticketNumber = value;
            }
        }

        public int NextTicketNumber
        {
            get
            {
                return nextTicketNumber;
            }
            set
            {
                nextTicketNumber = value;
            }
        }

        public DateTime TimeSlot
        {
            get
            {
                return timeSlot;
            }
            set
            {
                timeSlot = value;
            }
        }

    }
}
