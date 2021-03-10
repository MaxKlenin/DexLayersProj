using System;

namespace Object
{

    public class Doge
    {
        public String Name { get; set; }
        public int Weight { get; set; }
        public DateTime Time { get; set; }
        public bool IsVaccinated { get; set; }

        public Doge(String name, int weight, DateTime time, bool isVaccinated)
        {
            Name = name;
            Weight = weight;
            Time = time;
            IsVaccinated = isVaccinated;
        }
    }
}
