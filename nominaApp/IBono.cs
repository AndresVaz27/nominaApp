using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaApp
{
    internal interface IBono
    {
        decimal CalcularBono(string departamento);
	}
}
