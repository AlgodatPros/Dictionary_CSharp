using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.konkrete_Klassen;

namespace ConsoleApplication1
{
    class HashTabSepChain: Hashing
    {
        int key = 0;


        override public bool Search(int zahl)
        {
            key = hash(zahl);

            if ((HashTable[key] as SetUnsortedLinkedList).Search(zahl))
                return true;
            else
                return false; 
        }

        override public bool Insert(int zahl)
        {
            key = hash(zahl);

            if (!(HashTable[key] as SetUnsortedLinkedList).Search(zahl))
            {
                (HashTable[key] as SetUnsortedLinkedList).Insert(zahl);
                return true;
            }
            else
                return false;
        }

        override public bool Delete(int zahl)
        {
            key = hash(zahl);

            if ((HashTable[key] as SetUnsortedLinkedList).Search(zahl))
            {
                (HashTable[key] as SetUnsortedLinkedList).Delete(zahl);
                return true;
            }
            else
                return false;
        }

        override public void Print()
        {
            for (int i = 0; i < HashTable.Length; i++)
            {
                Console.Write("Reihe " + i + ": ");
                (HashTable[i] as SetUnsortedLinkedList).Print();                
            }
			Console.WriteLine ("=========");
        }
    }
}
