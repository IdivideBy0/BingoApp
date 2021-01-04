using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BingoApp.Helpers
{
    public class BdHelper
    {
        public List<int> Brow { get; set; }
        public List<int> Irow { get; set; }
        public List<int> Nrow { get; set; }
        public List<int> Grow { get; set; }
        public List<int> Orow { get; set; }

        public int totalBalls { get; set; }

        public KeyValuePair<int, char> lastCalledBall { get; set; }

        // Card stuff

        public int[] intRowB;
        public int[] intRowI;
        public int[] intRowN;
        public int[] intRowG;
        public int[] intRowO;

    }
}