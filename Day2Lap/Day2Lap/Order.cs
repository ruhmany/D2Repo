using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lap
{
    public class Order
    {
        public int ID { get; set; }
        public User user { get; set; }
	public int price { get; set; }
	public override string ToString()
        {
            return $"{ID}, {user.Name}, {price}";
        }
    }
}
