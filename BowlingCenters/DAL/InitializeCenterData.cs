using BowlingCenters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingCenters.DAL
{
    public class InitializeCenterData
    {
        public static IEnumerable<Center> GetCenters()
        {
            IList<Center> centers = new List<Center>
            {
                new Center
                {
                    ID = 1,
                    locationName = "Lucky Jack's",
                    locationAddress = "1705 S Garfield Ave",
                    locationCity = "Traverse City",
                    locationState = "MI",
                    locationZipCode = "49686"
                },
                new Center
                {
                    ID = 2,
                    locationName = "Incredible Mo's",
                    locationAddress = "1355 Silver Lake Crossings Blvd",
                    locationCity = "Grawn",
                    locationState = "MI",
                    locationZipCode = "49637"
                },
                new Center
                {
                    ID = 3,
                    locationName = "The Pines Sports Bar",
                    locationAddress = "5922 M-55",
                    locationCity = "Cadillac",
                    locationState = "MI",
                    locationZipCode = "49601"
                }
            };
            return centers;
        }
        


        
        
    }
}