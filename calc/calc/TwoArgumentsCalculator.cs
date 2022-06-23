using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace calc
{
    static class TwoArgumentsCalculator
    {
        public static double Creatror(string calculatorName)

        {
        switch (calculatorName)
            {
                case "Сложение":
                    Addition addition = new Addition();
                    return addition.Calculate(firstNum, secondNum);

                case "Вычитание":
                    Subtraction subtraction = new Subtraction();
                    return subtraction.Calculate(firstNum, secondNum);

                case "Умножение":
                    Multiplication multiplication = new Multiplication();
                    return multiplication.Calculate(firstNum, secondNum);
            }

        }
    }
}
