using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.DataAccesLayer
{
    public class SQLCountriesDAL : ICountriesDAL
    {
        private readonly IConfiguration Configuration;

        public SQLCountriesDAL(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<Country> GetAllCountriesIncludedInLifeExptancy(int lifeExptancy)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetContinentCountries(string continentCode)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetCountries()
        {
            List<Country> countries = null;

            try
            {
                string conString = ConfigurationExtensions.GetConnectionString(this.Configuration, "World_ConnectionString");

                using (SqlConnection sqlConnection = new SqlConnection(conString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    string queryAdo = @"SELECT Code, Name, Continent, Region, SurfaceArea, IndepYear, Population, LifeExpectancy, GNP, GNPOld, LocalName, GovernmentForm, HeadOfState, Capital, Code2 " +
                                       "FROM country";

                    sqlCommand.CommandText = queryAdo;
                    sqlCommand.Connection = sqlConnection;

                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            countries = new List<Country>();

                            while (sqlReader.Read())
                            {
                                countries.Add(new Country
                                {
                                    IsoCode = sqlReader["Code"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }

            return countries;
        }

        public Country GetCountryByIsoCode()
        {
            throw new NotImplementedException();
        }
    }
}
