using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository= songRepository;
        }
        public int AddNew(Song baseDto)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetAll()
        {
            throw new NotImplementedException();
        }

        public Song GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Song Update(Song baseDto)
        {
            throw new NotImplementedException();
        }
    }
}
