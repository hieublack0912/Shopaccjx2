﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Utilities.Exceptions
{
    public class shopException : Exception
    {
        public shopException()
        {
        }

        public shopException(string message) : base(message)
        {
        }

        public shopException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}