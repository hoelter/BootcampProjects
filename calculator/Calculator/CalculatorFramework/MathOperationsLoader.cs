using CalculatorFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFramework
{
    public static class MathOperationsLoader
    {
 
        public static List<IMathOperation> LoadMathOperations()
        {
            List<IMathOperation> operations = new List<IMathOperation>();
            IEnumerable<Type> mathOperationClassTypes = GetAllAssemblies().SelectMany(t => t.GetTypes()).Where(t => t.IsClass && t.Namespace == "MathOperations");
            foreach (Type operationType in mathOperationClassTypes)
            {
                operations.Add((IMathOperation)Activator.CreateInstance(operationType));
            }
            return operations;
        }

        private static List<Assembly> GetAllAssemblies()
        {
            List<Assembly> allAssemblies = new List<Assembly>();
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(filePath, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }
            return allAssemblies;
        }
    }
}
