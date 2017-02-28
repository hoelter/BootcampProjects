using CalculatorFramework;
using CalculatorFramework.Interfaces;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisplayCalculator display = new CommandLineDisplay();
            CalculatorController calculatorController = new CalculatorController(display);
            calculatorController.StartCalculator();
        }
    }
}
