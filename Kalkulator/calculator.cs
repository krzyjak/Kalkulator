using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{

    interface Icalculator
    {
        double AddNumbers(double firstNumber, double secondNumber);
        double SubNumbers(double firstNumber, double secondNumber);
        double MultiplyNumbers(double firstNumber, double secondNumber);
        double DivNumbers(double firstNumber, double secondNumber);
    }


    class calculator : Icalculator
    {
      private double firstNumber;
      private double secondNumber;

      public double FirstNumber   
      {
        get { return firstNumber; }   
        set { firstNumber = value; }  
      }

      public double SecondNumber
      {
       get { return secondNumber; }
       set { secondNumber = value; }
      }

     public double AddNumbers(double firstNumber, double secondNumber)
     {
      return this.firstNumber + this.secondNumber;
     }

     public double SubNumbers(double firstNumber, double secondNumber)
     {
      return this.firstNumber - this.secondNumber;
     }
        
     public double MultiplyNumbers(double firstNumber, double secondNumber)
     {
      return this.firstNumber * this.secondNumber;
     }

     public double DivNumbers(double firstNumber, double secondNumber)
     {
      return this.firstNumber / this.secondNumber;
     }

        
    }
}
