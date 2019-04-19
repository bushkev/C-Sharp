// Program 5
// CIS 200-01
// Fall 2018
// Due: 12/04/2018
// By: D9689

// Logic for the tree and treenode assignments, as well as traversing the tree.
using System;

namespace BinaryTreeLibrary
{
   // Generic class TreeNode declaration
   class TreeNode<T> where T : IComparable<T>
   {
      // automatic property LeftNode
      public TreeNode<T> LeftNode { get; set; }

      // automatic property Data
      public T Data { get; private set; }

      // automatic property RightNode
      public TreeNode<T> RightNode { get; set; }

        // Precondition:  None
        // Postcondition: initialize Data and make it a leaf node
        public TreeNode(T nodeData)
      {
         Data = nodeData;
      }

        // Precondition:  None
        // Postcondition: The values are compared and inserted in either the left or right node.
        public void Insert(T insertValue)
      {
         if (insertValue.CompareTo(Data) == -1) // insert in left subtree
         {
            // insert new TreeNode
            if (LeftNode == null)
            {
               LeftNode = new TreeNode<T>(insertValue);
            }
            else // continue traversing left subtree
            {
               LeftNode.Insert(insertValue);
            }
         } 
         else if (insertValue.CompareTo(Data) == 1) // insert in right subtree
            {
               // insert new TreeNode
               if (RightNode == null)
               {
                  RightNode = new TreeNode<T>(insertValue);
               }
               else // continue traversing right subtree
               {
                  RightNode.Insert(insertValue);
               }
            }
         }
      }

      // class Tree declaration
      public class Tree<T> where T: IComparable<T>
      {
         private TreeNode<T> root;  //variable used to hold the tree root 

        // Precondition:  None
        // Postcondition: The values is inserted in the proper treenode or root.
        public void InsertNode(T insertValue)
         {
            if (root == null)
            {
               root = new TreeNode<T>(insertValue);
            }
            else
            {
               root.Insert(insertValue);
            }
         }

        // Precondition:  None
        // Postcondition: The preoderhelper method is called and a new line is added
        public void PreorderTraversal()
         {
            PreorderHelper(root);
            Console.WriteLine();
         }

        // Precondition:  None
        // Postcondition: The values are travered and displayed in preorder format
        private void PreorderHelper(TreeNode<T> node)
         {
            if (node != null)
            {
               // output node Data              
               Console.Write($"{node.Data} ");
   
               // traverse left subtree        
               PreorderHelper(node.LeftNode);

               // traverse right subtree        
               PreorderHelper(node.RightNode);
            }
         }

        // Precondition:  None
        // Postcondition: The inoderhelper method is called and a new line is added
        public void InorderTraversal()
         {
            InorderHelper(root);
            Console.WriteLine();
        }

        // Precondition:  None
        // Postcondition: The values are travered and displayed in inorder format
        private void InorderHelper(TreeNode<T> node)
         {
            if (node != null)
            {
               // traverse left subtree       
               InorderHelper(node.LeftNode);

               // output node data              
               Console.Write($"{node.Data} ");

               // traverse right subtree       
               InorderHelper(node.RightNode);
            }
         }

        // Precondition:  None
        // Postcondition: The postoderhelper method is called and a new line is added
        public void PostorderTraversal()
         {
            PostorderHelper(root);
            Console.WriteLine();
        }

        // Precondition:  None
        // Postcondition: The values are travered and displayed in postorder format
        private void PostorderHelper(TreeNode<T> node)
         {
            if (node != null)
            {
               // traverse left subtree         
               PostorderHelper(node.LeftNode);

               // traverse right subtree         
               PostorderHelper(node.RightNode);

               // output node Data              
               Console.Write($"{node.Data} ");
            }
         }
      }
   } 


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/