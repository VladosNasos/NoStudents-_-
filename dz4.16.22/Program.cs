using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz4._16._22
{
    internal class Program
    {
        static void WhoIsMyDaddy()
        {
            Console.WriteLine("Creator of this shit-code only ME");
        }
        static void DoYouKnowDaRules()
        {
            Console.WriteLine("The first rule of fight club is \n ...you don't talk about fight club");
        }
        static void Loading()
        {
            bool staTus = true;

            Console.WriteLine("Your PC has too much porn. Download speed decreased");
            for (int i = 0; i < 10 && staTus == true; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine($"{i}0 percent loaded without ERROR");

            }
            Console.WriteLine("Your data was succesfuly published on Chinese MaoGram");
        }
        static void ImSad()
        {
            Console.WriteLine("Why you leaving me?...");
        }
        static void NewGay()
        {
            Console.WriteLine("Hey, you. Finally awake");
        }

        delegate void Message();



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Message message = ImSad;
            message += NewGay;
            message += Loading;
            message += DoYouKnowDaRules;
            message += WhoIsMyDaddy;

           
            //Message selectedMethod = (Message)message.GetInvocationList()[index];
            //selectedMethod();

            while (true)
            {
                Console.WriteLine("1-New game\n2-Load save\n3-Read the rules\n4-Credits \n0-Leave honorless");
                string input = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                if (int.TryParse(input, out int index) && index >= 0 && index <= 4)
                {
                    Message selectedMethod = (Message)message.GetInvocationList()[index ];
                    selectedMethod();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Очки купи,дичь пишешь");
                }
            }
        }
    }
}
