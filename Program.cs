using System;

namespace MyApp
{
    public class Program
    {
       static void Main(string[] args)
        {
         Validations(args);
          Execute(args); 
        }

      

         static void Validations(string[] args)
        {
             if (args.Length == 0 || args[0] != "bmi")
          {
            BadCommand();
            Environment.Exit(0);
          } 
          else if (args[1] == "--helps")
          {
            ShowHelp();
            Environment.Exit(0);
          }
          else if (args[1] == "--version")
          {
            ShowCurrentVersion();
            Environment.Exit(0);
          }

        }
         static void Execute(string[] args)
        {
            var firstSwitch = args[1];
            var firstArg = args[2];

            var secondSwitch = args[3];
            var secondArg = args[4];

            double hight , weight;

            switch (firstSwitch)
            {
                case "--hight":
                if (secondSwitch != "--weight")
                {
                    BadCommand();
                }
                hight = Convert.ToDouble(firstArg);
                weight = Convert.ToDouble(secondArg);
                calculatorBmi(hight , weight);
                 break;
                
                case "--weight":
                if (secondSwitch != "--hight")
                {
                    BadCommand();
                }
                weight = Convert.ToDouble(secondArg);
                hight = Convert.ToDouble(firstArg);
                calculatorBmi(hight , weight);
                 break;
                default:
                 BadCommand();
                   break;
            }
        }
         static  void BadCommand()
        {
            Console.WriteLine("Invalid command");
            Console.WriteLine("Use --helps to switch show helps");

        }
        static void ShowHelp()
        {
            Console.WriteLine("Use these switch to run program:");
            Console.WriteLine("--hight\tyour hight(centimeters)");
            Console.WriteLine("--weight\typur weight (kilogram)");
            Console.WriteLine("--version\tshow current version");
            Console.WriteLine("--helps\tshow command list");
        }
        static void ShowCurrentVersion()
        {
            Console.WriteLine("Current version is: 1.0");

        }
       static void calculatorBmi(double hight , double weight)
        {
          Console.WriteLine("\nYour bmi score is:");
          var bmi = Math.Round(weight /( hight * hight) );
          var status = "";

          if (bmi <= 18.4)
          {
            status = "Under weight";
          }
          else if (bmi > 18.4 && bmi <= 24.9)
          {
            status = "Normal";
          }
          else if (bmi >=25 && bmi <= 39.9)
          {
            status = "Over weight";
          }
          else if (bmi >= 40)
          {
            status = "Obese";
          }
          Console.WriteLine(bmi);
          Console.WriteLine($"Your status is : {status}");
        }
          static void Validations(object value)
        {
            throw new NotImplementedException();
        }
       
    }
}