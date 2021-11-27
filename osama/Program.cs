using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace RemovedNode
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> fantasy = new LinkedList<string>();

            LinkedListNode<string> Premierleague = fantasy.AddFirst("salah");

            fantasy.AddLast("kane");
            fantasy.AddAfter(Premierleague, "hazard");
            fantasy.AddBefore(Premierleague, "Ronaldo");
            fantasy.AddLast("Son");

            Console.WriteLine("The linked List Before Deletion: \n ");
            foreach (var item in fantasy)
            {

            }
            Console.WriteLine();
            Console.WriteLine("===============================");

            fantasy.RemoveFirst();
            fantasy.Remove("Son");
            fantasy.RemoveLast();

            Console.WriteLine("The linked List After Deletion: \n ");
            foreach (var item in fantasy)
            {

                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("===============================");

            Console.ReadKey();
        }

    }
}