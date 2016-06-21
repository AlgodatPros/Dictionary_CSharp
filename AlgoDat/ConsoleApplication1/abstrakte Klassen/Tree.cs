using System;

namespace DictionaryFramework
{
	public abstract class TreeNode<TNode> : INode<TNode>
	{

		public TreeNode()
		{

		}

		public TNode parent {
			get;
			set;
		}

		public TNode left {
			get;
			set;
		}

		public TNode right {
			get;
			set;
		}

		public int elem {
			get;
			set;
		}

	}

	public abstract class Tree<TNode> : IDictionary where TNode : INode<TNode>,  new()
	{
		protected TNode root = default(TNode);

		protected bool _Insert(int elem){
			TNode tmp = default(TNode);
			return _Insert (elem, ref tmp);
		}

		protected bool _Insert(int elem, ref TNode parentnode) {
			if (root == null) {
				root = new TNode ();
				root.elem = elem;
				root.parent = default(TNode);
			}
			else {
				TNode n = root;
				TNode parent;
				while (true) {
					if (n.elem == elem)
						return false;

					parent = n;

					bool nextLeft = n.elem > elem;
					n = nextLeft ? n.left : n.right;

					if (n == null) {
						if (nextLeft) {
							parent.left = new TNode();
							parent.left.elem = elem;
							parent.left.parent = parent;
						} else {
							parent.right = new TNode();
							parent.right.elem = elem;
							parent.right.parent = parent;
						}

						parentnode = parent; // set Node for rebalancing

						break;
					}
				}
			}
			return true;
		}

		public virtual bool Insert(int elem)
		{
			TNode tmp = default(TNode);
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

		private TNode _Search(int elem)
		{
			TNode pointer = root;
			while (pointer != null)
			{
				if (pointer.elem > elem)
					pointer = pointer.left;
				else if (pointer.elem < elem)
					pointer = pointer.right;
				else
					return pointer;
			}
			return default(TNode);

		}

		public virtual bool Delete(int elem)
		{
			return _Delete(default(TNode), elem);
		}

		protected bool _Delete(TNode node, int elem){
			TNode tmp = default(TNode);
			return _Delete(node, elem, ref tmp);
		}

		protected bool _Delete(TNode node, int elem, ref TNode parentnode)
		{

			if (node == null)
			{
				node = _Search(elem);
				if (node == null)
					return false;
			}

			if (node.left != null && node.right != null) //two children  			
			{
				TNode minNode = getMinNode(node.right);
				node.elem = minNode.elem;
				_Delete(minNode, minNode.elem);

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
						if ((INode<TNode>)node == (INode<TNode>)node.parent.left)
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
						if ((INode<TNode>)node == (INode<TNode>)node.parent.left)
							node.parent.left = node.left;
						else
							node.parent.right = node.left;

						parentnode = node.parent;
					}
				}
			}

			return true;
		}

		private TNode getMinNode(TNode rootNode)
		{
			TNode pointer = rootNode;

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

		protected void _Print(TNode root)
		{
			if (root != null)
			{
				_Print( root.left);
				Console.Write(" " + root.elem.ToString().PadLeft(2) );
				_Print( root.right);
			}
		}

		protected virtual void treeprint(TNode root, String prefix)
		{
			if (root == null)
			{
				Console.WriteLine(prefix + "+- <null>");
				return;
			}

			Console.WriteLine(prefix + "+- " + root.elem + " ("  +")");
			treeprint( root.left, prefix + "|  ");
			treeprint( root.right, prefix + "!  ");
		}

	}



}

