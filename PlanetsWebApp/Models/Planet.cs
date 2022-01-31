namespace PlanetsWebApp.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public string MassDisplay { get; set; }
        public int Diameter { get; set; }
        public double SunDistance { get; set; }
        public string ImagePath { get; set; }
    }
}
