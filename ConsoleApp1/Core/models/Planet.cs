using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Planet
    {
        public static int PlanetId { get; set; }
        private int _planetid = 0;
        public string Name { get; set; }
        public double Area { get; set; }
        public List<Country> Countries { get; set; }
       
        public Planet(string name, double area)
        {
            PlanetId = ++_planetid;
            Name = name;
            Area = area;
            
        }




    }
}
/*
 Planet Class
===================
PlanetId
Name
Area*/