using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanetsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetsWebApp.Data
{
    public interface IPlanetRepository
    {
        Task<List<Planet>> GetAllPlanets();
        Task<Planet> GetPlanetByName(string name);
    }

    public class PlanetRepository : IPlanetRepository
    {
        private readonly PlanetsWebAppContext _context;

        public PlanetRepository(PlanetsWebAppContext context)
        {
            _context = context;
        }

        public async Task<List<Planet>> GetAllPlanets()
        {
            var planets = await _context.Planet.ToListAsync();

            return planets;
        }

        public async Task<Planet> GetPlanetByName(string name)
        {
            var planets = await GetAllPlanets();

            var planet = planets.Where(p => p.Name == name).FirstOrDefault();

            return planet;
        }
    }
}
