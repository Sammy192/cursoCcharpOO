using System;
using System.Collections.Generic;
using System.Text;

namespace TratandoExcecao.Exception {
    class DomainException : ApplicationException{

        public DomainException(string message) : base(message) {
        }


    }
}
