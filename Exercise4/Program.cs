using System;

namespace Exercise4
{
    class Stack
    {
        private string[] desta;
        private int top;
        private int max;
        
        public Stack(int size)
        {
            desta = new string[22];
            top = -1;
            max = 22;
        }
        public void push (int element)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Pushed element is: ");
                desta[top] = Console.ReadLine();
            }
        }

    }
}
