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

      // public BarkSound BarkSounds;
        List<BarkSound> listSound { get; set; }
     

        public DogDoor() 
        {
            Status = false;
            listSound = new List<BarkSound>();
        }


        public void DoorOpen()
        {
          
            Status = true;
            Timer timer = new Timer(_ =>
            {
                DoorClose();
                Console.WriteLine("closed after 5 sec automatically");
            }, null, 3000, Timeout.Infinite);

        }

        public void DoorClose()
        {
           
            Status = false;
        }

        public bool IsDoorOpenClose()
        {
          //  Console.WriteLine(Status);
            return Status;
        }


        public void AddBarkSound(BarkSound barkSound)
        {
          // BarkSounds = barkSound;
           listSound.Add(barkSound);
           
        }

        public List<BarkSound> getAllowedSound()
        {
            return listSound;
        }
    }
}
