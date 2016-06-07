using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    abstract class Hashing : IDictionary
    {
		protected LinkedList[] HashTable = new LinkedList[10];
		

        protected void Init()
        {
            for (int i = 0; i < HashTable.Length; i++)
            {
                HashTable[i] = new SetUnsortedLinkedList();
            }
        }

        protected int hash(int x)
        {
            return x % 10;
        }

        abstract public bool Insert(int elem);
        abstract public bool Search(int elem);
        abstract public bool Delete(int elem);
        abstract public void Print();
    }
}
