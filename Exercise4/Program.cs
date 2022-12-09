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
    }
}
