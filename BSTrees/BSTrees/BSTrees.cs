using System;
namespace BSTrees
{
    public class BinaryTree
    {
        private Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void HardCode() {
            root = new Node(23);
            root.left = new Node(13);
            root.right = new Node(33);
            root.left.left = new Node(7);
            root.left.right = new Node(18);
            root.right.right = new Node(47);
          
        }
        public void InOrderTraversal() {
            if(root != null) {

                InOrderTraversalR(root);

            } else {

                Console.WriteLine("Tree is empty.");
            }

        }
        private void InOrderTraversalR(Node n) {   

            if (n.left != null) {
                InOrderTraversalR(n.left);
            }

           n.Display();

            if (n.right != null) {
                InOrderTraversalR(n.right);
            }
        }

        public void PreOrderTraversal () {
            //23, 13, 7, 18, 33, 47
            if (root != null) {
                PreOrderTraversalR(root);
            } else {
                Console.WriteLine("Tree is empty.");
            }
        }
        private void PreOrderTraversalR(Node n) {
            n.Display();
            if (n.left != null) {
                PreOrderTraversalR(n.left);
            }

            if (n.right != null) {
                PreOrderTraversalR(n.right);
            }


        }
        public void PostOrderTraversal() {
            //7, 18, 13, 47, 33, 23
            if (root != null) {
                PostOrderTraversalR(root);
            } else {
                Console.WriteLine("Tree is empty.");
            }

        }
        private void PostOrderTraversalR(Node n) {
            if (n.left != null) {
                PostOrderTraversalR(n.left);
            }
            if (n.right != null) {

                PostOrderTraversalR(n.right);
            }

           
            n.Display();











            //check if these work
        }
    }
}
