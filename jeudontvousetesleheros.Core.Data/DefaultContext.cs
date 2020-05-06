using jeudontvousetesleheros.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontvousetesleheros.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Propriétés
        public DbSet<Aventure> Aventures { get; set; }

        public DbSet<Paragraphe> Paragraphes { get; set; }
        #endregion
    }
}
