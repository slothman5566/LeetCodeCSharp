using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P733_FloodFill
{
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color)
            {
                return image;
            }
            DFS(image,sr,sc, image[sr][sc],color);
            return image;
        }
        protected void DFS(int[][] image, int sr, int sc, int sourceColor, int targetColor)
        {

            if (image[sr][sc] == sourceColor)
            {
                image[sr][sc] = targetColor;
                if (sr > 0)
                {
                    DFS(image, sr-1, sc, sourceColor, targetColor);
                }
                if (sc > 0)
                {
                    DFS(image, sr , sc-1, sourceColor, targetColor);
                }

                if (sr < image.Length-1)
                {
                    DFS(image, sr +1, sc, sourceColor, targetColor);
                }
                if (sc < image.First().Length - 1)
                {
                    DFS(image, sr , sc+1, sourceColor, targetColor);
                }

            }
        }
    }
}
