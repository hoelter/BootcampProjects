using CalculatorFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFramework
{
    public class CalculatorController
    {
        private IDisplayCalculator _display;
        private CalculatorServices _calc;

        public CalculatorController(IDisplayCalculator display)
        {
            _calc = new CalculatorServices();
            _display = InitializeDisplay(display);
        }

        public void StartCalculator()
        {
            while (true)
            {
                _display.ShowStartMenu();
                string input = _display.GetUserExpressionInput().ToLower();
                if (input != null || input != "q") //has to know that input may be 'q'
                {
                    string solution = _calc.ProcessUserInput(input);
                    if (solution != null)
                    {
                        _display.ShowUserSolution(solution);
                    }
                }
                else _display.ThrowUserInputError();
            }
        }

        private IDisplayCalculator InitializeDisplay(IDisplayCalculator display)
        {
            display.UpdateSupportedOperations(_calc.SupportedOperations);
            return display;
        }

    }
}
