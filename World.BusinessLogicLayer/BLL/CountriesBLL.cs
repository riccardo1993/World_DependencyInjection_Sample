using System;
using System.Collections.Generic;
using System.Text;
using World.DataAccesLayer;

namespace World.BusinessLogicLayer
{
    public class CountriesBLL
    {
        private readonly MyServiceFactory _factory;
        public CountriesBLL(MyServiceFactory factory)
        {
            _factory = factory;
        }

        public List<Country> GetCountries()
        {
            return _factory.Create("SQLCountriesDAL").GetCountries();
        }
    }
}
