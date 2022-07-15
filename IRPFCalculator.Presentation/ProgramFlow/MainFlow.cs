using IRPFCalculator.Presentation.Infra;
using IRPFCalculator.Presentation.ProgramFlow.Interface;
using IRPFCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPFCalculator.Presentation.ProgramFlow
{
    public class MainFlow : IMainFlow
    {
        private readonly ICalculator _calculator;
        private readonly IDetailedCalculator _detailedCalculator;

        public MainFlow(ICalculator calculator, IDetailedCalculator detailedCalculator)
        {
            _calculator = calculator;
            _detailedCalculator = detailedCalculator;
        }

        public void BeginApp()
        {
            NavigateMenu();
        }

        public void NavigateMenu()
        {
            var option = ScreenPresenter.GetOptions(Menu.MainMenu, 1, 3);

            switch (option)
            {
                case 1:
                    SimpleCalculation();
                    break;
                case 2:
                    DetailedCalculation();
                    break;
                case 3:
                    Exit();
                    break;
            }

            Console.WriteLine(Messages.PressToReturn);
            Console.ReadKey();
            BeginApp();

        }

        private void Exit()
        {
            Console.Clear();
            Console.WriteLine(Messages.PressToExit);
            Environment.Exit(0);
        }

        private void DetailedCalculation()
        {
            decimal value = ScreenPresenter.GetValue(Messages.Revenue, Messages.InvalidValue);
            Console.Clear();
            Console.WriteLine(Messages.Detail + _detailedCalculator.DetailedTaxCalculation(value));
        }

        private void SimpleCalculation()
        {
            decimal value = ScreenPresenter.GetValue(Messages.Revenue, Messages.InvalidValue);
            Console.Clear();
            Console.WriteLine(Messages.Result + _calculator.TaxCalculation(value).ToString("F2"));
        }
    }
}
