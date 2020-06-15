using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.DataAccesLayer
{
    public interface ICountriesDAL
    {
        List<Country> GetCountries();
        Country GetCountryByIsoCode();
        List<Country> GetContinentCountries(string continentCode);
        List<Country> GetAllCountriesIncludedInLifeExptancy(int lifeExptancy);
    }
}
