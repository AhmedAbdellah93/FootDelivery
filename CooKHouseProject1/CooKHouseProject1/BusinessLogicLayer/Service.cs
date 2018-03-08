using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo_Repository;
using CookHouseDB.DAL;

namespace CooKHouseProject1.BusinessLogicLayer
{
     class Service
    {
      UnitOfWork work = new UnitOfWork(new RestaurantContext());
        public Service()
        {
            work.Categorys.Create(new Category
            {
                Name="Sandwitch"
            });
        }
        public List<Governorate> GetAllGovernorate()
        {
         return work.Governorates.GetAll().ToList();
        }
        public List<Quarter> GetAllQuatrer(int GovID)
        {
            return work.Quarters.Filter(Q => Q.Governorate_ID == GovID).ToList();
        }

        public List<Restaurant_Branch> GetResurants(int GovId,int QrtId)
        {
            if(QrtId !=-1)
            {
                return work.Restaurant_Branches.Filter(Q => Q.Quarter_ID == QrtId).ToList();
            }
          else
            {
                var qrtList = work.Quarters.Filter(Q => Q.Governorate_ID == GovId);
             //  GetAllQuatrer(GovId); qrtList.AsEnumerable();
             var lst= work.Restaurant_Branches.Filter(r => qrtList.Contains(r.Quarter)).ToList();
                return lst;
            }
        }
    }
}