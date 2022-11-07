using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P211_DesignAddAndSearchWordsDataStructure
{
    public class WordDictionary
    {

        TrieNode _Root;
        public WordDictionary()
        {
            _Root = new TrieNode();

        }

        public void AddWord(string word)
        {
            var current = _Root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                    current.Children.Add(ch, new TrieNode());
                current = current.Children[ch];
            }

            current.IsFinished = true;
        }

        public bool Search(string word)
        {
            return Search(word, _Root,0);
        }

        protected bool Search(string word,TrieNode node,int index)
        {
            var current = node;
            for (int i = index; i < word.Length; i++)
            {
                var ch = word[i];
                if (ch == '.')
                {
                    foreach (var key in current.Children.Keys)
                    {
                        if (Search(word, current.Children[key],i+1))
                            return true;
                    }
                    return false;
                }
                else if (current.Children.ContainsKey(ch))
                    current = current.Children[ch];
                else
                    return false;
            }

            return current.IsFinished;
        }

        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();

            public bool IsFinished { get; set; }
        }
    }
}
