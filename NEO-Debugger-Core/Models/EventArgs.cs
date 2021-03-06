﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo.Debugger.Core.Models
{
    public class CompilerLogEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    public class DebugManagerLogEventArgs : EventArgs
    {
        public bool Error { get; set; }
        public string Message { get; set; }
    }

    public class LoadCompiledContractEventArgs : EventArgs
    {
        public string AvmPath { get; set; }
    }
}
