using System;
using System.Collections.Generic;
using System.Text;

namespace AmbiStore.Shared.Exceptions
{
    [Serializable]
    public class ErroDeValidacaoTEF : ApplicationException
    {
        public ErroDeValidacaoTEF(string message) : base(message)
        {

        }
        public ErroDeValidacaoTEF() : base()
        {

        }
    }

}
