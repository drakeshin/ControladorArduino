using ControladorJanela.Com;
using System;

namespace ConsoleControlador
{
    class Program
    {
        static void Main(string[] args)
        {
            ArduinoConnector com = new ArduinoConnector();
            foreach (var item in com.PortNames())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(com.PortConnect("COM1"));
            Console.WriteLine(com.WriteToPort("COM1", "la vai..."));
            Console.WriteLine(com.ReadFromPort("COM1"));
            Console.ReadKey();
        }


    }
}
