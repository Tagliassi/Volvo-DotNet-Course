using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo_DotNet_Course
{
    public interface IPais
    {
        bool VerificarPaises(Pais outroPais);
        bool VerificarPaisVizinho(Pais outroPais);
        double CalcularDensidadePopulacional();
        List<Pais> VizinhosComuns(Pais outroPais);
    }
}