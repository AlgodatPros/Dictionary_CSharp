using System;

namespace DictionaryFramework
{
	public interface INode<T>
	{
		T left
		{
			get;
			set;
		}

		T right
		{
			get;
			set;
		}

		T parent
		{
			get;
			set;
		}

		int elem {
			get;
			set;
		}
	}
}

