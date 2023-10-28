using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilhanetapidesafio.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime data { get; set; }
    }
}