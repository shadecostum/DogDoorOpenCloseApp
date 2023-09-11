using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpenCloseApp.Models
{
    public class DogDoor
    {

        public bool Status;

        public DogDoor() 
        {
           this.Status = false;
        }

        public void DoorOpen()
        {
            Console.WriteLine("Door Opened");
            Status = true;
        }

        public void DoorClose()
        {
            Console.WriteLine("Door Closed");
            Status = false;
        }

        public bool IsDoorOpenClose()
        {
            return Status;
        }
    }
}
