using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookHouseDB.DAL;

namespace Demo_Repository
{
     interface IUnitOfWork:IDisposable
    {
        IRepository<Category> Categorys { get; }
        IRepository<Client> Clients { get; }

        IRepository<Governorate> Governorates { get; }
        IRepository<Meals> ResutarntMeals { get; }

        IRepository<Meals_Order> ResutarntMealsOrder { get; }
        IRepository<Order> Orders { get; }

        IRepository<Quarter> Quarters { get; }
        IRepository<Restaurant> Restaurants { get; }
        IRepository<Restaurant_Branch> Restaurant_Branches{ get; }
     

        int Compelete();
    }
}
