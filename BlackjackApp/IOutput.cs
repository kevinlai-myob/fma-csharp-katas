using System;

namespace BlackjackApp
{
    public interface IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}