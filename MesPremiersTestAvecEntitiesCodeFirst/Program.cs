using System.Linq
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace MesPremiersTestAvecEntitiesCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultContext");


            DbContextOptionsBuilder optionBuilder = new DbContextOptionsBuilder();

            using (DefaultContext context = new DefaultContext(optionBuilder.Options))
            {
                var query = from droide in context.Droides
                            select droide;

                foreach(var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
