using System;

namespace Calculator
{

    class Program
    {
            static double newInput()//gets both inputs from the user and then passes it to math to calculate the result
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
            static double continueInput(double number1)//gets one input from the user and then takes the result of the previous calculation to the first number
            {
             double number2;

             Console.Write("what is the number you want to concatenate: ");
             double.TryParse(Console.ReadLine(),out number2);
             Console.Write("choose an operation: \n +:addition, \n -:subtraction, \n /:division, \n *:multiplication: ");
             string operation =Console.ReadLine();

             return math(operation,number1,number2);//returns the result of the operation
            }

            static double math(string operation,double number1,double number2)//calculates based on user prompt(the string operation)
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
                default ://this will clear the cache and start the user from scratch
                 return 0;
                case "continue"://this will make the first number the result of the last calculation
                 return 1;
                case "end"://this ends the program
                 return 2;
                
                
             }
            }
        static void Main(string[] args)
        {
            int flag= 0;//the default is 2 because of how check 
            double result = 0;
            
            while(flag!=2){//loops until the user types end at the prompt at the end

             double result2;//this stores the result we print to the user

             if(flag == 0){
              result = newInput();
              result2 = result;
             }
             else{//will go through this statement if the user entered continue at the prompt
              result2 = continueInput(result);
              }

              Console.WriteLine($"Your result is: {result2}");//prints out the result of the calculation

              Console.WriteLine("type end to end , type continue to continue with previous result or press enter to try again");
              flag = check();//checks to see what action the user wants to take and alters the flag accordingly
              
            }
        }
    }
}
