using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public abstract class SingleKeyDao<T, K> : BaseDao<T> where T : class
    {
        public T GetByPK(K key)
        {
            using (var context = DbContextCreator.Context())
            {
                return context.Set<T>()
                    .Where(IsKey(key))
                    .FirstOrDefault();
            }
        }

        //protected abstract Func<T, bool> IsKey(K key);
        //protected abstract Func<T, bool> IsKey { get; }
        //Func<int T,out TResult> TResult : 매서드의 반환 값 형식  


        protected abstract Expression<Func<T, bool>> IsKey(K key);
        //Expression<TDelegate>

        public void DeleteByPK(K key)
        {
            T entity = GetByPK(key);

            if (entity != null)
                Delete(entity);
        }

        public K GetMaxKey()  //GetMaxUserId
        {
            using (var context = DbContextCreator.Context())
            {
                var query = context.Set<T>()
                    .OrderByDescending(KeySelector)  //KeySelector = (x => x.UserId)
                    .Select(KeySelector);
                    //from x in context.Users
                            //orderby x.UserId descending
                            //select x.UserId;

                return query.FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, K>> KeySelector { get; }
    }
}
