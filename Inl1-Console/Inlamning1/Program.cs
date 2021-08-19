using System;
using System.Collections.Generic;

namespace Inlamning1
{
    /* Main program with the main-method*/
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int paid = 0;
            int price = 0;
            int exchange = 0; // ternary operator. Kanske kasta exception ifall för lite pengar?

            // Handle input
            Console.WriteLine("Welcome to the kiosk of Östlund \n");
            Console.WriteLine("Please enter the price of your shopping spree: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the amount of money you want to pay with (greater than or equal to " + price + "): ");
            paid = Convert.ToInt32(Console.ReadLine());

            // Make sure the given money is sufficient to pay the price.
            while (paid < price)
            {
                Console.WriteLine("Insufficient funds, please give me a descent amount of money!");
                paid = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate exchange
            exchange = paid - price;
            ExchangeCalculator ec = new ExchangeCalculator(exchange);

            Console.WriteLine("Calculating the exchange...");
            Console.WriteLine(ec.ToString());
            Console.ReadKey();
        }
    }

    /* An calculator for exchange */
    class ExchangeCalculator
    {

        /* Fields */
        int[] valors = new int[] { 500, 200, 100, 50, 20, 5, 2, 1 };
        Dictionary<int, int> exchange;
        int sum;

        /* Constructor */
        public ExchangeCalculator(int sum)
        {
            this.exchange = new Dictionary<int, int>();
            this.sum = sum;
            Calculate(sum);
        }

        /* Iterate each valid valor and calculate amount of valor in descending order */
        public void Calculate(int sum)
        {
            int units = 0; // temporary variable
            foreach (int v in this.valors)
            {
                if (v == 0 || sum < v) continue;
                units = sum / v; // round off downwards
                this.exchange.Add(v, units);
                sum = sum % (units * v);
            }
        }

        /* Custom designed toString to match the output of uppgiftslydelsen */
        public override string ToString()
        {
            String s = "";
            if (this.sum == 0) return "Even steven! No exchange back, I'm afraid.";
            foreach (KeyValuePair<int, int> e in this.exchange)
            {
                //s += "Valor: " + e.Key + ", amount of units: " + e.Value + "\n";
                
                if (e.Value != 0)
                {
                    String temp = e.Key <= 10 ? "coin(s)" : "bill(s)";
                    s += e.Value + " * " + e.Key + "-" + temp + "\n";
                }
            }

            // should obviously not be put here, but here it is.
            s += "... with a total of " + this.sum + ". Have a nice weekend!";
            return s;
        }


    } // end of ExchangeCalculator

}


