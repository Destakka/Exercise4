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
        public void pop(int element)
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return ;
            }
            else
            {
                Console.WriteLine 
                    ("poped element is: " + desta[top - 1]);
                return ;
            }
        }
        public void display (int element)
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine
                        ("Item[" + (i + 1) + "]: " + desta[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(22);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine(" 1. Push ");
                Console.WriteLine(" 2. Pop ");
                Console.WriteLine(" 3. Display ");
                Console.WriteLine(" 4. Exit ");
                Console.WriteLine(" \nEnter your choice: ");

                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "" : sInput);

                switch (ch)
                {
                    case '1':
                        s.push(22);
                        break;
                    case '2':
                        s.pop(22);
                        break;
                    case '3':
                        s.display(22);
                        break ;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
