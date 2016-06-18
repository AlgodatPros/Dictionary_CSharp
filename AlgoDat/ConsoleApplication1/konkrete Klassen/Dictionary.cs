using System;
using DictionaryFramework.konkrete_Klassen;

namespace DictionaryFramework
{
	//                         0              1                     2               3               4                 5
	public enum Multiset {SortedLinkedList,  SortedArray, UnsortedLinkedList, UnsortedArray, HashTabQuadProb, HashTabSepChain};
	public enum SortedMultiset {LinkedList = 0, Array};
	public enum UnsortedMultiset {LinkedList = 2, Array, HashTabQuadProb, HashTabSepChain};
	//                    6                        7                  8          9           10        11
	public enum Set {UnsortedLinkedList = 6, UnsortedArray, SortedLinkedList, SortedArray,  BinTree, AVLTree};
	public enum SortedSet {LinkedList = 8, Array, BinTree, AVLTree};
	public enum UnsortedSet {LinkedList = 6, Array};


	public class Dictionary
	{
		public static IDictionary Create(Multiset dict){
			return Create ((int)dict);
		}
		public static IDictionary Create(SortedMultiset dict){
			return Create ((int)dict);
		}
		public static IDictionary Create(UnsortedMultiset dict){
			return Create ((int)dict);
		}
		public static IDictionary Create(Set dict){
			return Create ((int)dict);
		}
		public static IDictionary Create(SortedSet dict){
			return Create ((int)dict);
		}
		public static IDictionary Create(UnsortedSet dict){
			return Create ((int)dict);
		}

		public static IDictionary Create(int dict)
		{
			switch (dict) {
			case 0:
				return new MultisetSortedLinkedList ();
			case 1:
				return new MultisetSortedArray ();
			case 2:
				return new MultisetUnsortedLinkedList ();
			case 3:
				return new MultisetUnsortedArray ();
			case 4:
				return new HashTabQuadProb ();
			case 5:
				return new HashTabSepChain ();
			case 6:
				return new SetUnsortedLinkedList ();
			case 7:
				return new SetUnsortedArray ();
			case 8:
				return new SetSortedLinkedList ();
			case 9:
				return new SetSortedArray ();
			case 10:
				return new BinTree ();
			case 11:
				return new AVLTree ();
			}

			return null;
		}
	}

	public class GDictionary <K> where K : IDictionary
	{
		public static K Create(Enum dict = null)
		{
			int dictnum = -1;
			if(typeof(K) != typeof(IDictionary)){
				throw new Exception("Use Dictionary.Create(...)");
			}

			if (dict.GetType () == typeof(Multiset)){
				if(typeof(K) != typeof(IMultiset))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(Multiset)dict;
			}
			if (dict.GetType () == typeof(SortedMultiset)) {
				if(typeof(K) != typeof(IMultiset))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(Multiset)dict;
			}
			if (dict.GetType () == typeof(UnsortedMultiset)) {
				if(typeof(K) != typeof(IMultisetUnsorted))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(UnsortedMultiset)dict;
			}
			if (dict.GetType () == typeof(SortedMultiset)){
				if(typeof(K) != typeof(IMultisetSorted))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(SortedMultiset)dict;

			}
			if (dict.GetType () == typeof(Set)) {
				if(typeof(K) != typeof(ISet))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(Set)dict;
			}
			if (dict.GetType () == typeof(UnsortedSet)) {
				if(typeof(K) != typeof(ISetUnsorted))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(UnsortedSet)dict;
			}
			if (dict.GetType () == typeof(SortedSet)) {
				if(typeof(K) != typeof(ISetSorted))
					throw new Exception ("Incompatible Enum");
				else
					dictnum = (int)(SortedSet)dict;
			}

			switch (dictnum) {
				case 0:
				return (K)(IMultisetSorted) new MultisetSortedLinkedList ();
				case 1:
				return (K)(IMultisetSorted) new MultisetSortedArray ();
				case 2:
				return (K)(IMultisetUnsorted) new MultisetUnsortedLinkedList ();
				case 3:
				return (K)(IMultisetUnsorted) new MultisetUnsortedArray ();
				case 4:
				return (K)(IMultisetUnsorted) new HashTabQuadProb ();
				case 5:
				return (K)(IMultisetUnsorted) new HashTabSepChain ();
				case 6:
				return (K)(ISetUnsorted) new SetUnsortedLinkedList ();
				case 7:
				return (K)(ISetUnsorted) new SetUnsortedArray ();
				case 8:
				return (K)(ISetSorted) new SetSortedLinkedList ();
				case 9:
				return (K)(ISetSorted) new SetSortedArray ();
				case 10:
				return (K)(ISetSorted) new BinTree ();
				case 11:
				return (K)(ISetSorted) new AVLTree ();
			}

			return default(K);
		}
	}
}

