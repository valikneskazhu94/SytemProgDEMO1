using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ProcessSimple();
           // ProcessThreadMethod();
            ProcessStartMethod();
           
        }

        private static void ProcessStartMethod()
        {
            //Process proc = new Process();
            //proc.StartInfo = new ProcessStartInfo("calc.exe");
            //proc.Start();

            Process.Start("calc.exe");
        }

        private static void ProcessThreadMethod()
        {
            Process procStudio = Process.GetProcessesByName("devenv")[0];
            ProcessModuleCollection processThread = procStudio.Modules;
            foreach(ProcessModule thread in processThread)
            {
                Console.WriteLine($"ID: {thread.ModuleName}; Size: {thread.ModuleMemorySize}");
            }
        }

        private static void ProcessSimple()
        {
            foreach (Process item in Process.GetProcesses())
            {
                //выводим на экран Id и Name запущенных процессов
                Console.WriteLine($"{ item.Id} : {item.ProcessName}");
            }
            Console.WriteLine("_________");

            //получаем ID приложения по названию
            Process[] procStudio = Process.GetProcessesByName("chrome");
            //Console.WriteLine($"Microsoft Visual Studio ID: {procStudio.Id}");
            Thread.Sleep(2000);
            foreach (Process process in procStudio)
            {
                Console.WriteLine(process.ProcessName);
                process.CloseMainWindow();
                process.Close();
            }
        }
    }
}
