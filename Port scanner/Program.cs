using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Port_scanner
{
    internal class Program
    {
        private static string IP = "";

        static void Main(string[] args)
        {
            UserInput();
            PortScan();
            Console.ReadKey();
        }

        private static void UserInput()
        {
            Console.Write("IP Address: ");
            IP = Console.ReadLine();
        }

        private static void PortScan()
        {
            Console.Clear();
            TcpClient Scan = new TcpClient();
            foreach (int s in Ports)
            {
                try
                {
                    Scan.Connect(IP, s);
                    Console.WriteLine($"[{s}] | OPEN");
                }
                catch
                {
                    Console.WriteLine($"[{s}] | CLOSED");
                }
            }
        }

        private static int[] Ports = new int[]
        {
        21,
        22,
        80
        };
    }
}
