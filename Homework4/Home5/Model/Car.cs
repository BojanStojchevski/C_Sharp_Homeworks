using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5.Model
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            int speed = Speed * driver.Level;
            return speed;
        }
    }
}
