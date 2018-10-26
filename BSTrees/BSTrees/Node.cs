using System;
namespace BSTrees
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node Left {
            get {
                return this.left;
            } set {
                this.left = value;
            }
        }
        public Node Right {
            get {
                return this.right;
            }
        }

        public int Data {
            get {
                return data;
            } // set {
            //    data = value;
            //}
        }
        public Node(int data) {

            this.data = data;
        }
        public void Display() {

            Console.WriteLine(data);
        }
    }
}
