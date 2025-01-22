using System;
using System.Collections.Generic;

// Shopping Cart Program (With Classes)

/*
Things
- item
- menu
- cart
 */

// a function does one thing
// a class reps one thing


class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Shopping Cart Program (With Classes)\n");
     
        Cart cart = new Cart();
        Menu menu = new Menu();
        Choice choice = new Choice();

        bool done = false;
        while (!done)
        {
            menu.Display();
            int choiceInt = choice.GetChoice();

            if (choiceInt == 1)
            {
                cart.Add();
            } else if (choiceInt == 2)
            {
                // cart.Remove();
            } else if (choiceInt == 3)
            {
                double total = cart.CalcTotal();
                Console.WriteLine(total);
            } else if (choiceInt == 4)
            {
                cart.Display();
            }
            else
            {
                done = true;
            }
        }
        
    }
}

