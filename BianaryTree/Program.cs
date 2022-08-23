﻿using System;

namespace BianaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Problem");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            ///UC1: Add the node in the tree

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);

            //UC2:Find the size of tree

            int Size = BinaryTree.GetSize();
            Console.WriteLine(Size);

            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);
        }
    }
}