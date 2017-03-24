using System;
using DataStructures;

namespace trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            
            System.Console.WriteLine($"Hola exists: {trie.WordExists("Hola")}");                        
            trie.AddWord("Hola");
            System.Console.WriteLine($"Hola exists: {trie.WordExists("Hola")}");
            trie.AddWord("Hols");
            System.Console.WriteLine($"Hol exists: {trie.WordExists("Hol")}");            
            trie.AddWord("Hoppip");
            trie.AddWord("Hopapa");
            System.Console.WriteLine($"Hoppip exists: {trie.WordExists("Hoppip")}");                        
            trie.AddWord("Hoppapa");
            trie.AddWord("Yeah");
            trie.AddWord("Yes");            
            trie.AddWord("");
            System.Console.WriteLine($"<Empty> exists: {trie.WordExists("")}"); 
        }
    }
}
