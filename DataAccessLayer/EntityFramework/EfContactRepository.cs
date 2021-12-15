using DataAccessLayer.Repositories;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contacts>, IContactDal
    {
       
    }
}
