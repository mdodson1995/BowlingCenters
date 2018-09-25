using BowlingCenters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingCenters.DAL
{
    public interface ICenterRepository
    {
        IEnumerable<Center> SelectAll();
        Center SelectOne(int id);
        void Insert(Center center);
        void Update(Center center);
        void Delete(int id);

    }
}