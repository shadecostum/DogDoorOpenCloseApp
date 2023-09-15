using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpenCloseApp.Models
{
    internal class BarkRecoganizer
    {
        DogDoor DogDoor { get; set; }

        public BarkRecoganizer(DogDoor door)
        {
            DogDoor = door;
        }

        public void DogBark( string dogsound,out string feedback)
        {
            List<BarkSound> sounds = DogDoor.getAllowedSound();
            string sound = dogsound;

            foreach (var item in sounds)
            {
                if ( item.getSoundStored()==sound)
                {
                    if (DogDoor.IsDoorOpenClose())
                    {
                        DogDoor.DoorClose();
                        
                    }
                    else
                    {
                        Console.WriteLine(sound);
                        DogDoor.DoorOpen();
                        
                        feedback = $"automatic door opened";
                        return;
                    }
                }
            }

            feedback = "Dog sound coun't be identify .........";

        }

    }
}
