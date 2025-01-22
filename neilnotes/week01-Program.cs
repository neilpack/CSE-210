using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ------------------------------------------------------
        // Data types
        // int, float, double, string, bool
        int x = 9;                  // 4B -2B -> 2B
        long ll = 9L;               // 8B
        float gpa = 3.543F;         // 4B: 8 - 9 SD
        double gpa2 = 3.3456345;    // 8B: 19 SD
        string name = "bob";
        bool happy = true;

        x = 100;
        
        // ------------------------------------------------------
        // WriteLine() and Write()
        // print('Hello World')
        Console.WriteLine("Hello World");
        Console.WriteLine(gpa);
        
        System.Console.WriteLine("One Line");
        System.Console.Write("--same--");
        System.Console.Write("--same--");
        System.Console.Write("--same--");
        System.Console.Write("--same--");
        System.Console.WriteLine();

        // ------------------------------------------------------
        // Operators: math
        x = 1 + 5;


        // ------------------------------------------------------
        // Operators: logic
        // if x != 9
        // <, >, <=, >=, 
        int a = 10;
        int b = 20;

        if (a != b)
        {
            Console.WriteLine("yes");
        }
        

        // ------------------------------------------------------
        // Operators: // and %
        int answer = 20 / 7;
        System.Console.WriteLine(answer);

        int y = 20;
        x = 7;
        double answerD = (double)(y / x);
        System.Console.WriteLine(answerD);

        // ------------------------------------------------------
        // Short operations (+=)
        int m = 9;
        m += 9;
        System.Console.WriteLine(m);
        System.Console.WriteLine("The value of m = " + m);

        // ------------------------------------------------------
        // increment and decrement operators
        int age = 99;
        age += 1;
        age++;
        age--;
        ++age;
        --age;


        // ------------------------------------------------------
        // ReadLine()
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        // ------------------------------------------------------
        // Conversions (int.Parse() and Convert)
        // age = int('34')


        // ------------------------------------------------------
        // if statement
        // age = 34
        // if age >= 18:
        //     print('Can vote')
        // else:
        //     print('Can not vote')


        // ------------------------------------------------------
        // AND, OR and NOT operators
        // &&, ||, !
        // if a < 10 and b < 10:
        if (a < 10 && b < 10)
        {
            
        }
        

        // ------------------------------------------------------
        // formatted strings
        // age = 34
        // name = 'Bob
        // print(f'My name is {name}, my age is {age}')


        // ------------------------------------------------------
        // While loops
        // input = "yes"
        // while input == yes:
        //     input = prompt("Do you want to continue? ");


        // ------------------------------------------------------
        // do while loop

        // ------------------------------------------------------
        // For loops
        // for i in range(10, 40, 7):
        //     print(i)

    }
}

