using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions {
    public class BootcampException : Exception { //must inherit from an exception when creating an exception

        public BootcampException() : base() { }

        public BootcampException(string message) : base(message) { }

        public BootcampException(string message, Exception innerexception) : base(message, innerexception) { }


    }
}
