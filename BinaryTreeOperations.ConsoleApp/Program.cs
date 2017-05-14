using BinaryTreeOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeOperations.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(50);

            Console.WriteLine("Max Height: {0}", tree.GetMaxHeight());

            tree.AddNode(20);
            Console.WriteLine("Max Height: {0}", tree.GetMaxHeight());

            tree.AddNode(10);
            Console.WriteLine("Max Height: {0}", tree.GetMaxHeight());

            tree.AddNode(60);
            Console.WriteLine("Max Height: {0}", tree.GetMaxHeight());

            tree.AddNode(30);
            Console.WriteLine("Max Height: {0}", tree.GetMaxHeight());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
