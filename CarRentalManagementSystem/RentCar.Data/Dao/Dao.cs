using RentCar.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class Dao
    {
        public static UserDao User { get; } = new UserDao();
        public static ArtistDao Artist { get; } = new ArtistDao();
        public static PlaylistTrackDao PlaylistTrack { get; } = new PlaylistTrackDao();
        public static TrackDao Track { get; } = new TrackDao();
        public static PlaylistDao Playlist { get; } = new PlaylistDao();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

<<<<<<< Updated upstream
        public void Method()
        {
            throw new System.NotImplementedException();
        }

        //public static AdminDao Admin = new AdminDao();
=======
        public override string ToString()
        {
            return base.ToString();
        }
>>>>>>> Stashed changes
    }
    }
}
}
