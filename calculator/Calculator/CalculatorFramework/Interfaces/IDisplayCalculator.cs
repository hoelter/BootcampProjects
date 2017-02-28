using System.Collections.Generic;

namespace CalculatorFramework.Interfaces
{
    public interface IDisplayCalculator
    {
        void ShowStartMenu();
        string GetUserExpressionInput();
        void UpdateSupportedOperations(List<IMathOperation> supportedOperations);
        void ShowSupportedOperations();
        void ThrowUserInputError();
        void ShowUserSolution(string solution);
    }
}
