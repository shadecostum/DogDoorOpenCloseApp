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
        BarkRecoganizer barkRecoganizer;
        public DoorStimulator() 
        { 
           
            DogDoor dogDoor = new DogDoor();//constructor insid onlu assign
            dogDoor.AddBarkSound(new BarkSound("rowlf"));
            dogDoor.AddBarkSound(new BarkSound("rooowlf"));
            dogDoor.AddBarkSound(new BarkSound("roowlf"));
            dogDoor.AddBarkSound(new BarkSound("rawlf"));
            dogDoor.AddBarkSound(new BarkSound("woofl"));
             remote = new Remote(dogDoor);
             barkRecoganizer = new BarkRecoganizer(dogDoor);

        }
       
        public void Run()
        {
            string feedback = "";
          
            Console.WriteLine("Fido Dog barks Rowlf");

            barkRecoganizer.DogBark("rowlf",out feedback);
            Console.WriteLine(feedback);
            //remote.RemoteClicked();
            Console.WriteLine("\nFido Dog has gone outside...");
           

            try
            {
                Thread.Sleep(5000); // Sleep for 10,000 milliseconds (10 seconds)
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("======================================================");


            Console.WriteLine("\nNeighbour dog starts barking...");
            barkRecoganizer.DogBark("bow bow", out feedback);
            Console.WriteLine(feedback);
            //remote.RemoteClicked();
            Console.WriteLine("========================================================");
            Console.WriteLine("FIdo bark Rowlf");

            barkRecoganizer.DogBark("woofl", out feedback);
            Console.WriteLine(feedback);

            Console.WriteLine("\nFido's back inside...");

            try
            {
                Thread.Sleep(5000); // Sleep for 10,000 milliseconds (10 seconds)
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("========================================================");
            Console.WriteLine("\nNeighbour dog starts barking...");
            barkRecoganizer.DogBark("bowosss",out feedback);
            Console.WriteLine(feedback);
            Console.WriteLine("========================================================");
        }

      
    }
}
