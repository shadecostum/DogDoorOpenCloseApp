using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpenCloseApp.Models
{
    public class BarkSound
    {
        private string SoundStored { get; set; }//encapsulated

        public BarkSound(string soundStored)
        { this.SoundStored = soundStored; }

        public string getSoundStored()
        { return SoundStored; }

    }
}
