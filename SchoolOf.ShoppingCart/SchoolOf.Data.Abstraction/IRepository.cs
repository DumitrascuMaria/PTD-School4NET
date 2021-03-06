using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Data.Abstraction
{
    public interface IRepository<T> where T : BaseEntityModel
    {
        Task<T> GetById(long id);
       T  Add(T entity);
        Task<bool> DeleteByIdAsync(long id);
        Task<T> UpdateAsync(T entity);

        IEnumerable<T> Find(Func<T, bool> searchCriteria);//(product)=>product.deleted
        //func<input,output>=delegate(pointer la functie)

    }
}
