using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    // FRAMEWORK DOES NOT SUPPORT HAVING A SPACE/BLANK CHARACTER AS THE SYMBOL FOR A MATH OPERATION
    public static class MathOperationsLibrary
    {
        // All function names for calculator need to follow convention 'Get{Classname}Operations", see below for example
        // MathOperation's that have symbol that utilize invalid operation characters will be dropped when called by their respective calculator.
        public static List<IMathOperation> GetNormalCalculatorOperations()
        //{
        //    IMathOperation multiplication =  new Multiplication{
        //        Name = "Multiplication"
        //        ,Symbol = "*"
        //        ,RequiredFunction = "Multiply"
        //    };
        //    IMathOperation division = new IMathOperation {
        //        Name = "Division"
        //        ,Symbol = "/"
        //        ,RequiredFunction = "Divide"
        //    };
        //    IMathOperation addition  = new IMathOperation {
        //        Name = "Addition"
        //        ,Symbol = "+"
        //        ,RequiredFunction = "Add"
        //        ,HigherOperations = new List<IMathOperation> { multiplication, division }
        //    };
        //    IMathOperation subtraction = new IMathOperation {
        //        Name = "Subtraction"
        //        ,Symbol = "-"
        //        ,RequiredFunction = "Subtract"
        //        ,HigherOperations = new List<IMathOperation> { multiplication, division }
        //    };
        //    List<IMathOperation> normalCalculatorOperations = new List<IMathOperation> { multiplication, division, addition, subtraction };
        //    return normalCalculatorOperations;
        //}


    }
}
