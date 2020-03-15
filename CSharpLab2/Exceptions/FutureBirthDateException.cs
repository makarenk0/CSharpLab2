using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2.Exceptions
{
    class FutureBirthDateException : ArgumentOutOfRangeException
    {
        public DateTime Value{ get; }
        public FutureBirthDateException(DateTime val) : base("Your birth date can`t be in the future!")
        {
            Value = val;
        }
    }
}
