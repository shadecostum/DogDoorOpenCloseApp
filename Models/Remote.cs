using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DoorOpenCloseApp.Models
{
    public class Remote
    {
        public DogDoor dogDoor;
       

        public Remote(DogDoor door) 
        {
            dogDoor = door;
        }

        public void RemoteClicked()
        {
            Console.WriteLine("Press the Remote");
            if (dogDoor.IsDoorOpenClose())
            {
                dogDoor.DoorClose();
                Console.WriteLine("Door closed");

            }
            else
            {
 
                Console.WriteLine("opening the door");
                dogDoor.DoorOpen();
               
                Timer timer = new Timer(_=>
                {
                    dogDoor.DoorClose();
                    Console.WriteLine("closed after 5 sec automatically");
                }, null, 3000, Timeout.Infinite);


            }

        }
       


    }
}
