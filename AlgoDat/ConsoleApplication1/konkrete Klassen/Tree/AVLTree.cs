using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{
	public class AVLTree : BinTree {

		public override bool Insert(int elem) {
			TreeNode parentnode = null;
			bool result = _Insert(elem, ref parentnode);
			if (result) {
				if (parentnode != null) {
					rebalance (parentnode);
				}
			}
			return result;
		}



		public override bool Delete(int elem) {
			TreeNode parentnode = null;
			bool result = _Delete (null, elem, ref parentnode);
			if (result) {
				if (parentnode != null) {
					rebalance (parentnode);
				}
			}
			return result;
		}

		private void rebalance(TreeNode n) {
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

		private TreeNode rotateLeft(TreeNode a) {

			TreeNode b = a.right;
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

		private TreeNode rotateRight(TreeNode a) {

			TreeNode b = a.left;
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

		private TreeNode rotateLeftThenRight(TreeNode n) {
			n.left = rotateLeft(n.left);
			return rotateRight(n);
		}

		private TreeNode rotateRightThenLeft(TreeNode n) {
			n.right = rotateRight(n.right);
			return rotateLeft(n);
		}

		private int height(TreeNode n) {
			if (n == null)
				return -1;
			return 1 + Math.Max(height(n.left), height(n.right));
		}


		private void setBalance(params TreeNode[] nodes) {
			foreach (var n in nodes) {
				n.balance = height(n.right) - height(n.left);
			}

		}

	}
}
