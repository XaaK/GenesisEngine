﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenesisEngine
{
    public interface IHeightfieldGenerator
    {
        double GetHeight(DoubleVector3 location, int level, double scale);
    }
}
