using NUnit.Framework;
namespace Leetcode
{
    public class P2065
    {
        [Test]
        public void Test1()
        {
            var values = new int[] {1,2,3};
            var edges = new int[][]
            {
                new int[] {100,101,102},
                new int[] {110,111,112},
                new int[] {120,121,122},
            };
            Assert.AreEqual(101, edges[0][1]);
            Assert.AreEqual(120, edges[2][0]);

            var twoD = new int[,] 
            {
                {100,101,102},
                {110,111,112},
                {120,121,122}
            };
            Assert.AreEqual(101, twoD[0,1]);
            Assert.AreEqual(120, twoD[2,1]);

            Assert.AreEqual(1, MaximalPathQuality(values,edges,100));
        }
        public int MaximalPathQuality(int[] values, int[][] edges, int maxTime)
        {
            return 1;

        }
    }
}
