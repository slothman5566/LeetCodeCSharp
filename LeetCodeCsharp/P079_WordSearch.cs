using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P079_WordSearch
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            for(var y=0;y<board.Length; y++)
            {
                for(var x=0;x<board[0].Length; x++)
                {

                    if (DFS(board, word, x, y, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected bool DFS(char[][] board, string word, int x, int y, int index)
        {
            if (index == word.Length)
            {
                return true;
            }
            if(x < 0 || y < 0 || x >= board[0].Length || y >= board.Length)
            {
                return false;
            }

            if (board[y][x] != word[index])
            {
                return false;
            }
            else
            {
                var save = board[y][x];
                board[y][x] = '0';
                var result = DFS(board, word, x+1, y, index + 1) ||
                    DFS(board, word, x-1, y, index + 1) ||
                    DFS(board, word, x, y+1, index + 1) ||
                    DFS(board, word, x, y-1, index + 1);

                board[y][x] = save;
                return result;
            }




        }
    }
}
