using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using World.DataAccesLayer;
using System.Collections.Generic;
using World.BusinessLogicLayer;

namespace DependencyInjectionSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyServiceFactory _dependencyFactory;

        private List<Country> _countries;

        public IndexModel(MyServiceFactory dependencyFactory)
        {
            _dependencyFactory = dependencyFactory;
        }

        public async Task OnGetAsync()
        {
            _countries = new CountriesBLL(_dependencyFactory).GetCountries(); //here we pass to BLL the DAL using constuctor via DI
        }
    }
}
