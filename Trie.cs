using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Trie
    {
        char _endChar = '\0';
        TrieNode root = null;
        public Trie()
        {
            root = new TrieNode();
        }

        public void AddWord(string word){
            root.AddWord(word);
        }

        public bool WordExists(string word)
        {
            var result = false;
            result = root.HasWord(word);
            return result;
        }
    }

    class TrieNode
    {
        char _endChar = '\0';
        public char Value { get; private set; }
        public Dictionary<char,TrieNode> Children { get; private set; }
        
        public TrieNode()
        {
            Value = _endChar;
            Children = new Dictionary<char,TrieNode>();
        }
        public TrieNode(char c)
        {
            Value = c;
            Children = new Dictionary<char,TrieNode>();
        }
        public void AddWord(string word){

            var currentNode = this;

            foreach(char c in word){
                if(currentNode.Children.ContainsKey(c)){
                    System.Console.WriteLine($"{c} exists");
                    currentNode = currentNode.Children[c];
                } else {
                    System.Console.WriteLine($"{c} doesn't exists so new node is created");
                    var newTrieNode = new TrieNode(c);
                    currentNode.Children.Add(c, newTrieNode);
                    currentNode = newTrieNode;
                }
            }

            if(!currentNode.Children.ContainsKey(_endChar)){
                System.Console.WriteLine($"End Char added");
                currentNode.Children.Add(_endChar, new TrieNode(_endChar));
            }
        }

        internal bool HasWord(string word)
        {
            var result = false;
            TrieNode current = this;
            foreach(char c in word){
                if(current.Children.ContainsKey(c)){
                    current = current.Children[c];
                } else {
                    break;
                }
            }

             
             
             

            result = current.Children.ContainsKey(_endChar);

            return result;
        }
    }
}