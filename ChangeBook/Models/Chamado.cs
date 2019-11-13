using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChangeBook.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Login { get; set; }
    }
}