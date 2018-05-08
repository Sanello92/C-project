using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock_Alarm
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter time Alarm (hh:mm)");

            string input = Console.ReadLine();

            Alarm alarm = new Alarm();


            alarm.WakeUp += Alarm_WakeUp;
            alarm.SetAlarm(input);

            
            Console.ReadLine();

        }

        private static void Alarm_WakeUp(object sender, string e)
        {
            Alarm alarm = (Alarm) sender;
            Console.WriteLine($"{e}");
        }
    }
}
