﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public class Fruit : IBlendable
    {
        public abstract string Blend();
    }
}
