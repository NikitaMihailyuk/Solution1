﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9_2
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {
        }
    }
}