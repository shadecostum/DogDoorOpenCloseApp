using DoorOpenCloseApp.Models;

namespace DoorOpenCloseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DoorStimulator doorStimulator = new DoorStimulator();
            doorStimulator.Run();
        }
    }
}