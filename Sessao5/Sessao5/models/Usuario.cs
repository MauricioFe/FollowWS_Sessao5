using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao5.models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Nascimento { get; set; }
        public Byte[] Foto { get; set; }
        public string Sexo { get; set; }
        public int TimeFavoritoId { get; set; }
        public string perfil { get; set; }
    }
}
