using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontvousetesleheros.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés

        public int Id { get; set; }
        public string Titre { get; set; }
        #endregion
    }
}
