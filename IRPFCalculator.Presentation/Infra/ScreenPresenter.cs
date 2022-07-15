using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPFCalculator.Presentation.Infra
{
    public class ScreenPresenter
    {
        public static string Show(string screen, string errorMessage = "")
        {
            Console.Clear();

            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                Console.WriteLine();
                Console.WriteLine(errorMessage);
            }

            return Console.ReadLine();
        }

        public static int GetOptions(string screen, int initialOption, int endOption, string customMessage = null)
        {
            int option = 0;
            bool validInput = false;
            var messages = string.Empty;

            while (!validInput)
            {
                validInput = (int.TryParse(Show(screen, messages), out option) && option >= initialOption && option <= endOption);

                if (validInput)
                {
                    break;
                }
                else
                {
                    messages = customMessage ?? "Opção inválida!";
                }
            }

            return option;
        }

        public static string GetInput(string screen, Predicate<string> predicate, string customMessage = null)
        {
            string input;
            var messages = string.Empty;

            while (!predicate.Invoke(input = Show(screen, messages)))
                messages = customMessage ?? "Opção Inválida";

            return input;
        }

        public static decimal GetValue(string screen, string customMessage = null)
        {
            decimal value = 0;
            bool validInput = false;
            var messages = string.Empty;

            while (!validInput)
            {
                validInput = (decimal.TryParse(Show(screen, messages), out value) && value > 0);

                if (validInput)
                {
                    break;
                }
                else
                {
                    messages = customMessage ?? "Opção inválida!";
                }
            }

            return value;

        }
    }
}
