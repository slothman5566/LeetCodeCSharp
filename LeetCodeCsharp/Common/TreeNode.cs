﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        public TreeNode(int x,TreeNode left,TreeNode right) { val = x; this.left = left;this.right = right; }

        public static TreeNode BuildTreeNode(List<int?> list)
        {
            var node = list.Select(x =>
            {
                if (x == null)
                {
                    return null;
                }
                return new TreeNode(x.Value);
            }).ToList();
;

            for (var i = 1; i < node.Count; i++)
            {
               

                if (node[i] != null )
                {
                   
                    if (i % 2 == 1)
                    {
                        node[(i-1) / 2].left = node[i];
                    }
                    else if(i%2==0){
                        node[(i-1) / 2].right = node[i];
                    }
                   
                }

            }
            return node.First();
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
