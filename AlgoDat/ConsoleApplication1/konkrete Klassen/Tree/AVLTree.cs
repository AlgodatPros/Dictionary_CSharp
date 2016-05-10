using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Tree;

namespace ConsoleApplication1.Tree{
	public class AVLTreeNode : TreeNode<AVLTreeNode> {
		public int balance = 0;
	}
}

namespace ConsoleApplication1.konkrete_Klassen
{
	public class AVLTree : Tree<AVLTreeNode> {

		public override bool Insert(int elem) {
			AVLTreeNode parentnode = null;
			bool result = _Insert(elem, ref parentnode);
			if (result) {
				if (parentnode != null) {
					rebalance (parentnode);
				}
			}
			return result;
		}

		public override bool Delete(int elem) {
			AVLTreeNode parentnode = null;
			bool result = _Delete (null, elem, ref parentnode);
			if (result) {
				if (parentnode != null) {
					rebalance (parentnode);
				}
			}
			return result;
		}

		private void rebalance(AVLTreeNode n) {
			setBalance(n);

			if (n.balance == -2) {
				if (height(n.left.left) >= height(n.left.right))
					n = rotateRight(n);
				else
					n = rotateLeftThenRight(n);

			} else if (n.balance == 2) {
				if (height(n.right.right) >= height(n.right.left))
					n = rotateLeft(n);
				else
					n = rotateRightThenLeft(n);
			}

			if (n.parent != null) {
				rebalance(n.parent);
			} else {
				root = n;
			}
		}

		private AVLTreeNode rotateLeft(AVLTreeNode a) {

			AVLTreeNode b = a.right;
			b.parent = a.parent;

			a.right = b.left;

			if (a.right != null)
				a.right.parent = a;

			b.left = a;
			a.parent = b;

			if (b.parent != null) {
				if (b.parent.right == a) {
					b.parent.right = b;
				} else {
					b.parent.left = b;
				}
			}

			setBalance(a, b);

			return b;
		}

		private AVLTreeNode rotateRight(AVLTreeNode a) {

			AVLTreeNode b = a.left;
			b.parent = a.parent;

			a.left = b.right;

			if (a.left != null)
				a.left.parent = a;

			b.right = a;
			a.parent = b;

			if (b.parent != null) {
				if (b.parent.right == a) {
					b.parent.right = b;
				} else {
					b.parent.left = b;
				}
			}

			setBalance(a, b);

			return b;
		}

		private AVLTreeNode rotateLeftThenRight(AVLTreeNode n) {
			n.left = rotateLeft(n.left);
			return rotateRight(n);
		}

		private AVLTreeNode rotateRightThenLeft(AVLTreeNode n) {
			n.right = rotateRight(n.right);
			return rotateLeft(n);
		}

		private int height(AVLTreeNode n) {
			if (n == null)
				return -1;
			return 1 + Math.Max(height(n.left), height(n.right));
		}


		private void setBalance(params AVLTreeNode[] nodes) {
			foreach (var n in nodes) {
				n.balance = height(n.right) - height(n.left);
			}

		}

		protected override void treeprint(AVLTreeNode root, String prefix)
		{
			if (root == null)
			{
				Console.WriteLine(prefix + "+- <null>");
				return;
			}

			Console.WriteLine(prefix + "+- " + root.elem + " (" + root.balance +")");
			treeprint( root.left, prefix + "|  ");
			treeprint( root.right, prefix + "!  ");
		}

	}
}
