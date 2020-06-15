using System;
using System.Collections.Generic;
using System.Text;
using World.DataAccesLayer;
using Microsoft.Extensions.DependencyInjection;

namespace World.BusinessLogicLayer
{
    public class MyServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public MyServiceFactory(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public ICountriesDAL Create(string dataAccessThier)
        {
            //dataAccessThier = "SQLCountriesDAL"; //TODO use Enum

            if (dataAccessThier == "SQLCountriesDAL")  
            {
                return (ICountriesDAL)_serviceProvider.GetService(typeof(SQLCountriesDAL));
            }
            else
            {
                return null;
            }
        }
    }
}
