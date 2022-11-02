using System;
using Car_simulator;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector = new Vector3(1, 2, 3);
            
            Cars porshe = new Cars("porshe", vector, 0100);
            porshe.KeyValid(0100);
            porshe.Start();
            porshe.Move(new Vector3(1, 3, 5));
            porshe.Move(new Vector3(1, 3, 5));
            Console.WriteLine(porshe.GetInfo());

        }
    }
}