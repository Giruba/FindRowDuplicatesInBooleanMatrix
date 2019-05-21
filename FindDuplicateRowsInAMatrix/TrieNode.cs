using System;
using System.Collections.Generic;
using System.Text;

namespace FindDuplicateRowsInAMatrix
{
    class TrieNode
    {
        private bool isEndOfWord;
        private TrieNode[] children;

        public TrieNode() { }

        public void SetTrieNodeEndofWord(bool value) {
            isEndOfWord = value;
        }

        public void SetTrieNodeChildren(TrieNode[] trieNodes) {
            children = trieNodes;
        }

        public void Insert(TrieNode root, Char[] charArray) {

            for (int index = 0; index < charArray.Length; index++) {
                int currentIndexOfWord = charArray[index] - '0';
                if (root.children[currentIndexOfWord] == null)
                {
                    root.children[currentIndexOfWord] = new TrieNode();
                }
                root = root.children[currentIndexOfWord];
                root.SetTrieNodeChildren(new TrieNode[26]);
            }
        }

        public bool isFound(TrieNode root, Char[] charArray) {

            for (int index = 0; index < charArray.Length; index++) {
                int currentTrieNodeIndex = charArray[index] - '0';
                if (root.children[currentTrieNodeIndex] == null)
                {
                    return false;
                }
                root = root.children[currentTrieNodeIndex];
            }

            return true;
        }
    }
}
