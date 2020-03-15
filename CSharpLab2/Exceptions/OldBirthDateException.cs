using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2.Exceptions
{
    class OldBirthDateException : ArgumentOutOfRangeException
    {
        public DateTime Value { get; }
        public OldBirthDateException(DateTime val) : base("Your birth date can`t be so old!")
        {
            Value = val;
        }
    }
}
