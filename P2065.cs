using NUnit.Framework;
using System.Collections.Generic;
using System;
namespace Leetcode
{
    public class P2065
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
            Assert.AreEqual(75, new Solution().MaximalPathQuality(new int[] { 0, 32, 10, 43 }, new int[][] { new int[] { 0, 1, 10 }, new int[] { 1, 2, 15 }, new int[] { 0, 3, 10 } }, 49));
        }
        public class Solution
        {
            int[][] edges;
            int[] values;
            Dictionary<int, List<int>> g = new Dictionary<int, List<int>>();
            Dictionary<string, int> t = new Dictionary<string, int>();
            bool[] visited;
            int maxQuality = -1;
            public int MaximalPathQuality(int[] values, int[][] edges, int maxTime)
            {
                this.edges = edges;
                this.values = values;
                visited = new bool[values.Length];
                BuildGraph();
                BuildTimes();
                Dfs(0, 0, maxTime);
                return this.maxQuality;
            }
            void BuildGraph()
            {
                foreach (var e in edges)
                {
                    if (!g.ContainsKey(e[0]))
                    {
                        g.Add(e[0], new List<int>());
                    };
                    if (!g.ContainsKey(e[1]))
                    {
                        g.Add(e[1], new List<int>());
                    };
                    g[e[0]].Add(e[1]);
                    g[e[1]].Add(e[0]);
                }
            }
            void BuildTimes()
            {
                foreach (var e in edges)
                {
                    t[Key(e[0], e[1])] = e[2];
                }
            }
            string Key(int u, int v)
            {
                string key = "";
                if (u < v)
                {
                    key = u + "," + v;
                }
                else
                {
                    key = v + "," + u;
                }
                return key;
            }
            void Dfs(int node, int quality, int time)
            {
                if (time < 0)
                {
                    return;
                }

                if (!visited[node])
                {
                    visited[node] = true;
                    quality += values[node];
                }

                if (node == 0)
                {
                    maxQuality = Math.Max(quality, maxQuality);
                }

                foreach (int next in g[node])
                {
                    Dfs(next, quality, time - t[Key(node, next)]);
                }
            }
        }
    }
}
