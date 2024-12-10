﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator.Coffee
{
    public interface ICoffee
    {
        string GetDescription();
        double GetPrice();
    }
}