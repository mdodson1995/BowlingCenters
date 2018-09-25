using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BowlingCenters.DAL;
using BowlingCenters.Models;


namespace BowlingCenters.DAL
{
    public class CenterRepository : ICenterRepository, IDisposable
    {
        private IEnumerable<Center> centers;


        public CenterRepository()
        {
            centers = (IEnumerable<Center>)HttpContext.Current.Session["centers"];
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            centers = null;
        }

        public void Insert(Center center)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Center> SelectAll()
        {
            return centers;
        }

        public Center SelectOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Center center)
        {
            throw new NotImplementedException();
        }
    }
}