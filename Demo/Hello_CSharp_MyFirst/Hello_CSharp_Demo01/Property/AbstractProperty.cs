﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Property
{
    abstract class AbstractProperty
    {
        public abstract string Name { get; set; }
        public abstract string Code { get; }

    }
}