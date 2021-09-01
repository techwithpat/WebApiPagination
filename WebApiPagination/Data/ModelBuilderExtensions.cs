using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebApiPagination.Entities.Models;

namespace WebApiPagination.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedTeams(modelBuilder);
        }

        private static void SeedTeams(ModelBuilder modelBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var teamsFile = "WebApiPagination.Data.SeedData.teams.csv";

            using var stream = assembly.GetManifestResourceStream(teamsFile);
            using var reader = new StreamReader(stream, Encoding.UTF8);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var teams = csv.GetRecords<Team>();

            foreach (var team in teams)
                modelBuilder.Entity<Team>().HasData(team);
        }
    }
}
