using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();

        }

        private static void Start()
        {
            Console.Clear();

            string printerName = "";
            string choice = "";

            Console.WriteLine("Make a selection: ");
            Console.WriteLine("1 - Get All Printers");
            Console.WriteLine("2 - Get Printer Information");
            Console.WriteLine("3 - Delete Printer");
            Console.WriteLine("0 - Exit Program");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.Write("Selection: ");

            choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Exiting Program ...");
                return;
            }

            Console.WriteLine(@"Enter printer name (\\computername\printername): ");
            Console.WriteLine();

            printerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    PrinterSettings.GetAllPrinters(printerName);
                    break;
                case "2":
                    PrinterSettings.GetPrinterInfo(printerName);
                    break;
                case "3":
                    if(PrinterSettings.DeletePrinter(printerName))
                    {
                        Console.WriteLine("{0} was successfully deleted.", printerName);
                        break;
                    }
                    Console.WriteLine("{0} was not deleted.", printerName);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue ");
            Console.ReadLine();

            Start();
        }

    }
}
