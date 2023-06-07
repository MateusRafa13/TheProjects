using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProva.Mapeamento
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public bool AcessaUsuarios { get; set; }
        public bool AcessaInternados { get; set; }
        public bool AcessaMedicamentos { get; set; }
        public bool ativo { get; set; }

    }
}
