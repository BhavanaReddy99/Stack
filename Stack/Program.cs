using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    
    public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class Stack
        {
            public Node Top { get; private set; }

            public bool IsEmpty()
            {
                return Top == null;
            }

            public void Push(int data)
            {
                Node newNode = new Node(data);
                newNode.Next = Top;
                Top = newNode;
            }

            public bool Pop(out int element)
            {
                if (IsEmpty())
                {
                    element = 0; // You can choose any default value
                    return false; // Indicate that the operation failed
                }

                element = Top.Data;
                Top = Top.Next;
                return true; // Indicate a successful pop
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                Stack stack = new Stack();

                // Push elements onto the stack
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);

                // Pop elements from the stack and display them
                Console.WriteLine("Stack Elements:");
                int element;
                while (stack.Pop(out element))
                {
                    Console.WriteLine(element);
              
                }
            Console.ReadLine();
        }
        }

    }
