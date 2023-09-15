using DoorOpenCloseApp.Models;

namespace DoorOpenCloseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new BarkSound("rowlf")
           DoorStimulator doorStimulator = new DoorStimulator();
           
            doorStimulator.Run();
        }
    }
}