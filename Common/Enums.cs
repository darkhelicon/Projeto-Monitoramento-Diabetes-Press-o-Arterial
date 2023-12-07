using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum MedType 
    {
        Glico,
        Hiper,
        Outro
    }
    public enum Days 
    {
        Hoje = 1,
        Ontem = 2,
        UltimaSemana = 3,
        UltimoMes = 4
    }
    public enum Categoria
    {
        Hipotensao = 1,
        PressaoArterialNormal = 2,
        PreHipertensao = 3,
        HipertensaoEstagioUm = 4,
        HipertensaoEstagioDois = 5,
        CriseHipertensiva
    }
}
