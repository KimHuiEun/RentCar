﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Exceptions
{
    public class FakeVirtualMemberException : Exception
    {
        public FakeVirtualMemberException(string fakeMethodName)
        {
            FakeMethodName = fakeMethodName;
        }

        public string FakeMethodName { get; }
    }
}
