using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpenCloseApp.Models
{
   public class DoorStimulator
    {
        Remote remote;
        public DoorStimulator() 
        {
            DogDoor dogDoor = new DogDoor();//constructor insid onlu assign

           remote = new Remote(dogDoor);
        }
       
        public void Run()
        {
            Console.WriteLine("Fido Dog barks bow bow");
            remote.RemoteClicked();

            Console.WriteLine("Fido Dog goes outside ");
            Console.WriteLine("\nFido Dog has gone outside...");



            try
            {
                Thread.Sleep(5000); // Sleep for 10,000 milliseconds (10 seconds)
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("...but he's in outside!");

            Console.WriteLine("\nFido dog starts barking...");
             Console.WriteLine("...so Gina grabs the remote control.");
            remote.RemoteClicked();

            Console.WriteLine("\nFido's back inside...");

            try
            {
                Thread.Sleep(5000); // Sleep for 10,000 milliseconds (10 seconds)
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }
}
