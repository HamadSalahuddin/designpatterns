using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilderDesignPattern
{
    public class CarBuilderFacade
    {
        public Car Car { get; set; }

        public CarBuilderFacade()
        {
            Car = new Car();
        }

        public Car Build()
            => Car;

        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarAddressBuilder Built => new CarAddressBuilder(Car);
    }
}
