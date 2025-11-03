using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DniNoValidoException:ApplicationException
    {
        public DniNoValidoException():base(){}
        public DniNoValidoException(string message):base(message){}
        public DniNoValidoException(string message, Exception innerException):base(message, innerException){}
    }
}
