﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpLua.Ast
{
    public class Variable
    {
        public string Name;
        public bool IsGlobal = false;
        public int References = 0;
    }
}
