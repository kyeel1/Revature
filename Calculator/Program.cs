using System;

namespace Calculator
{

    class Program
    {
            static double newInput()//gets inputs from the user and then passes it to math to calculate the result
            {
             double number1;
             double number2;

             Console.Write("what is the first number: ");
             double.TryParse(Console.ReadLine(),out number1);
             Console.Write("what is the second number: ");
             double.TryParse(Console.ReadLine(),out number2);
             Console.Write("choose an operation: \n +:addition, \n -:subtraction, \n /:division, \n *:multiplication: ");
             string operation =Console.ReadLine();

             return math(operation,number1,number2);//returns the result of the operation
            }
            static double continueInput(double number1)//gets inputs from the user and then passes it to math to calculate the result
            {
             double number2;

             Console.Write("what is the number you want to concatenate: ");
             double.TryParse(Console.ReadLine(),out number2);
             Console.Write("choose an operation: \n +:addition, \n -:subtraction, \n /:division, \n *:multiplication: ");
             string operation =Console.ReadLine();

             return math(operation,number1,number2);//returns the result of the operation
            }

            static double math(string operation,double number1,double number2)//calculates 
            {
                switch(operation)
                {
                 case "+":
                 case "addition":
                 return number1+number2;

                 case "-" :
                 case "subtraction" :
                 return number1-number2;

                 case "/" : 
                 case "division": 
                 return number1/number2;

                 case "*" :
                 case "multiplication" :
                 return number1*number2;

                 default:
                 return 0;
                }
            }

            static int check()//this checks to see if the user wants to end the program, mess with the current result, or start from scratch
            {
             string status = Console.ReadLine();
             switch(status)
             {
                case "end":
                 return 0;
                case "continue":
                 return 1;
                default :
                 return 2;
             }
            }
        static void Main(string[] args)
        {
            int flag= 2;
            double result = 0;
            
            while(flag!=0){
             double result2;
             if(flag == 2){
              result = newInput();
              result2 = result;
             }
             else{
              result2 = continueInput(result);
              }
              Console.WriteLine($"Your result is: {result2}");

              Console.WriteLine("type end to end , type continue to continue with previous result or press enter to try again");
              flag = check();
              
            }
        }
    }
}
