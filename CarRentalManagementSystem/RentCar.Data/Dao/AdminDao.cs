using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Dao
{
    class AdminDao
    {
        protected override Expression<Func<Admin, bool>> IsKey(int key)
        {
            return x => x.AlbumId == key;
        }

<<<<<<< Updated upstream
        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public void Insert()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }

        protected override Expression<Func<Admin, int>> KeySelector
        {
            get
            {
                return x => x.AdminId;
            }
        }
=======
        protected override Expression<Func<Album, int>> KeySelector =>
            x => x.AlbumId;
>>>>>>> Stashed changes
    }
}
