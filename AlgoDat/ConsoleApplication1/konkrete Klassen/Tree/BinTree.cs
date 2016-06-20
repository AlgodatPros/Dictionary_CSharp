using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryFramework.Tree;

namespace DictionaryFramework.Tree{
	public class BinTreeNode : TreeNode<BinTreeNode>{ }
}
namespace DictionaryFramework.konkrete_Klassen
{
	public class BinTree : Tree<BinTreeNode>, ISetSorted{	}
}

