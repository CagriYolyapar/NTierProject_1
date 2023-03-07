using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Commands

        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modification Commands

        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Expression

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T,bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp)where X : class;

        //Find 

        T Find(int id);

        //Get Last Datas

        List<T> GetLastDatas(int number);

        //Get First Datas

        List<T> GetFirstDatas(int number);

        //GetCounted Datas

        List<T> GetCountedDatas(int number);

        
    }
}
