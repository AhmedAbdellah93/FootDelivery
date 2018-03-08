
using Demo_Repository;
using CookHouseDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository
{
     class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantContext pcontext;
        public UnitOfWork(RestaurantContext context)
        {
            pcontext = context;
            Categorys = new Repository<Category>(pcontext);
            Clients = new Repository<Client>(pcontext);

        
            Governorates = new Repository<Governorate>(pcontext);
            Orders = new Repository<Order>(pcontext);
            Quarters = new Repository<Quarter>(pcontext);
            Restaurants = new Repository<Restaurant>(pcontext);

            Restaurant_Branches = new Repository<Restaurant_Branch>(pcontext);

            ResutarntMeals = new Repository<Meals>(pcontext);
            ResutarntMealsOrder = new Repository<Meals_Order>(pcontext);
        }

        public IRepository<Category> Categorys
        { get; private set;}

        public IRepository<Client> Clients
        { get; private set; }

        public IRepository<Governorate> Governorates
        { get; private set; }

        public IRepository<Order> Orders
        { get; private set; }

        public IRepository<Quarter> Quarters
        { get; private set; }

        public IRepository<Restaurant> Restaurants
        { get; private set; }

        public IRepository<Restaurant_Branch> Restaurant_Branches
        { get; private set; }

        public IRepository<Meals> ResutarntMeals
        { get; private set; }

        public IRepository<Meals_Order> ResutarntMealsOrder
        { get; private set; }

       
        public int Compelete()
        {
            return pcontext.SaveChanges();
        }

        public void Dispose()
        {
            pcontext.Dispose();
        }
    }
}
