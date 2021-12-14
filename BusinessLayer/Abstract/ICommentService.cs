using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICommentService
    {
        void CommmentAdd(Comment comment);

        //void CategoryDelete(Category category);
        //void CategoryUpdated(Category category);

        List<Comment> GetList(int id);
        //Category GetById(int id);
    }
}
