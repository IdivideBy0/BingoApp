﻿using System;
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
    }
}