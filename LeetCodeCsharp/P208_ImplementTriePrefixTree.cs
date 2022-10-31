using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P208_ImplementTriePrefixTree
{
    public class Trie
    {
        TrieNode _Root=new TrieNode();
        public Trie()
        {

        }

        public void Insert(string word)
        {
            var currentNode = _Root;

            foreach (var ch in word)
            {
                if (!currentNode.Children.ContainsKey(ch ))
                    currentNode.Children[ch ] = new TrieNode();
                currentNode = currentNode.Children[ch ];
            }

            currentNode.IsFinished = true;
        }

        public bool Search(string word)
        {
            var currentNode = _Root;

            foreach (var ch in word)
                if (!currentNode.Children.ContainsKey(ch ))
                    return false;
                else
                    currentNode = currentNode.Children[ch ];

            return currentNode.IsFinished;
        }

        public bool StartsWith(string prefix)
        {
            var currentNode = _Root;

            foreach (var ch in prefix)
                if (!currentNode.Children.ContainsKey(ch ))
                    return false;
                else
                    currentNode = currentNode.Children[ch ];

            return true;
        }
    }
}
