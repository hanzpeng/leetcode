using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Leetcode
{
    public class P0098
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        Dictionary<TreeNode, int> Min = new Dictionary<TreeNode, int>();
        Dictionary<TreeNode, int> Max = new Dictionary<TreeNode, int>();
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            if (!IsValidBST(root.left) || !IsValidBST(root.right)) return false;
            if (root.left == null && root.right == null)
            {
                Min[root] = root.val;
                Max[root] = root.val;
                return true;
            }

            if (root.left != null)
            {
                if (Max[root.left] >= root.val)
                {
                    return false;
                }
                Min[root] = Min[root.left];
            }
            else
            {
                Min[root] = root.val;
            }

            if (root.right != null)
            {
                if (Min[root.right] <= root.val)
                {
                    return false;
                }
                Max[root] = Max[root.right];
            }
            else
            {
                Max[root] = root.val;
            }

            return true;
        }
    }
}
