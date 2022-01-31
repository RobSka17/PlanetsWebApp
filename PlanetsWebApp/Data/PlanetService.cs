using Microsoft.AspNetCore.Mvc;
using PlanetsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetsWebApp.Data
{
    public interface IPlanetService
    {
        Task<List<Planet>> GetAllPlanets();
        Task<Planet> GetPlanetByName(string name);
    }

    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public async Task<List<Planet>> GetAllPlanets()
        {
            var planets = await _planetRepository.GetAllPlanets();

            return planets;
        }

        public async Task<Planet> GetPlanetByName(string name)
        {
            var planet = await _planetRepository.GetPlanetByName(name);

            return planet;
        }
    }
}
