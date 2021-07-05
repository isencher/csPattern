using System;

namespace MarvellousWorks.PracticalPattern.Concept.Delegating
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeList ivlt = new InvokeList();
            ivlt.Invoke();
            Console.Write(ivlt[0]);
            Console.Write(ivlt[1]);
            Console.Write(ivlt[2]);
        }
    }
}
