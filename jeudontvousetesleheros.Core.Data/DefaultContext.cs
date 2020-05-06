using jeudontvousetesleheros.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontvousetesleheros.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Propriétés
        public DbSet<Aventure> Aventures { get; set; }
        #endregion
    }
}
