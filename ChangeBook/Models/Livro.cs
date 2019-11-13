using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChangeBook.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome_livro { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ano { get; set; }
        public string Edicao { get; set; }
        public bool Disponibilidade { get; set; }
    }
}