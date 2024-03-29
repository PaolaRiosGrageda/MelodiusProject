﻿using MelodiusDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(MelodiusContext melodiusContext) : base(melodiusContext)
        {

        }
    }
}
