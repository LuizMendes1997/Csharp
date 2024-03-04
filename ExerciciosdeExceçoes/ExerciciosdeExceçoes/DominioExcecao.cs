using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosdeExceçoes
{
    internal class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string message) : base(message){ }
    }
}
