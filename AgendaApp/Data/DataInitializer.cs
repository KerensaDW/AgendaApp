using Microsoft.AspNetCore.Identity;
using AgendaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data
{
    public class DataInitializer
    {
        private readonly AgendaAppContext _context;
        private readonly UserManager<Gebruiker> _userManager;
        List<string> names = new List<string>
            {
                "klant1",
                "bart.staels",
                "guido.heuvinck",
                "marc.vanorshoven",
                "eddi.dewinter",
                "ferdinand.vti",
                "bart.daem",
                "buyle.vanmol",
                "luc.vandenberghe",
                "marleen.heyse",
                "lieve.bracke",
                "hadewych.uyttersprot",
                "marijke.jonckheere",
                "mieke.vanmol",
                "ingrid.vd",
                "liliane.veldeman",
                "marie.louise.lostrie"
            };

        public DataInitializer(AgendaAppContext context, UserManager<Gebruiker> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task InitializeData()
        {
            //_context.Database.EnsureDeleted();
            //_context.Database.EnsureCreated();
            
            foreach (var name in names)
            {
                await _userManager.CreateAsync(new Gebruiker { UserName = name, Email = "email@gmail.com", Gebruikernr = names.IndexOf(name)+1 }, "W@chtwoord1");
            }
            
            _context.SaveChanges();
        }
    }
}
