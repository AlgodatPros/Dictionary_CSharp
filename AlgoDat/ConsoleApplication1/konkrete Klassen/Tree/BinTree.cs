using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.konkrete_Klassen
{

	public class TreeNode
	{
		public int balance = 0;
		public int elem;
		public TreeNode left, right, parent = null;

		public TreeNode(int _elem, TreeNode _parent = null)
		{
			elem = _elem;
			parent = _parent;
		}
	}

	public class BinTree : IDictionary 
	{
		public TreeNode root = null;

		public bool _Insert(int elem, ref TreeNode parentnode) {
			if (Search (elem)) {
				return false;
			}
			if (root == null) {
				root = new TreeNode (elem, null);
			}
			else {
				TreeNode n = root;
				TreeNode parent;
				while (true) {
					if (n.elem == elem)
						return false;

					parent = n;

					bool nextLeft = n.elem > elem;
					n = nextLeft ? n.left : n.right;

					if (n == null) {
						if (nextLeft) {
							parent.left = new TreeNode(elem, parent);
						} else {
							parent.right = new TreeNode(elem, parent);
						}

						parentnode = parent;
						//Console.WriteLine ("parent: " + parent.elem);
						//treeprint(root,"", false);
						//rebalance(parent);
						break;
					}
				}
			}
			return true;
		}



		public virtual bool Insert(int elem)
		{
			TreeNode tmp = null;
			return _Insert(elem, ref tmp);
		}

		public bool Search(int elem)
		{
			if (_Search(elem) != null)
			{
				return true;
			}
			return false;
		}

		TreeNode _Search(int elem)
		{
			TreeNode pointer = root;
			while (pointer != null)
			{
				if (pointer.elem > elem)
					pointer = pointer.left;
				else if (pointer.elem < elem)
					pointer = pointer.right;
				else
					return pointer;
			}
			return null;

		}

		public virtual bool Delete(int elem)
		{
			TreeNode tmp = null;
			return _Delete(null, elem, ref tmp);
		}

		public bool _Delete(TreeNode node, int elem, ref TreeNode parentnode)
		{

			if (node == null)
			{
				node = _Search(elem);
				if (node == null)
					return false;
			}

			if (node.left != null && node.right != null) //two children  			
			{
				TreeNode minNode = getMinNode(node.right);
				node.elem = minNode.elem;
				TreeNode tmp = null;
				_Delete(minNode, minNode.elem, ref tmp);

			}
			else
			{ //one or zero child
				if (node.left == null)
				{
					if (node.parent == null)
						root = node.right;
					else
					{
						if (node.right != null)
						{
							node.right.parent = node.parent;
						}
						if (node == node.parent.left)
							node.parent.left = node.right;
						else
							node.parent.right = node.right;

						parentnode = node.parent;
					}
				}
				else if (node.right == null)
				{
					if (node.parent == null)
						root = node.left;
					else
					{
						node.left.parent = node.parent;
						if (node == node.parent.left)
							node.parent.left = node.left;
						else
							node.parent.right = node.left;

						parentnode = node.parent;
					}
				}
			}

			return true;
		}

		public TreeNode getMinNode(TreeNode rootNode)
		{
			TreeNode pointer = rootNode;

			while (pointer.left != null)
			{
				pointer = pointer.left;
			}
			return pointer;
		}

		public virtual void Print()
		{

			_Print(root);
			Console.WriteLine();
			treeprint(root, "");

		}

		public void _Print(TreeNode root)
		{
			if (root != null)
			{
				_Print( root.left);
				Console.Write(" " + root.elem.ToString().PadLeft(2) );
				_Print( root.right);
			}
		}

		private void treeprint(TreeNode root, String prefix)
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

