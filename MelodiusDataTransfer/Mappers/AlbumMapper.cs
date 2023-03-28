using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTransfer.Mappers
{
    public class AlbumMapper
    {
        public static Album DtoToModel(AlbumDto artistDto)
        => new Album()
        {
            Id = artistDto.Id,
            Title = artistDto.Title,
            ReleaseDate = artistDto.ReleaseDate,
        };

        public static AlbumDto ModelToDto(Album artist)
        => new AlbumDto()
        {
            Id = artist.Id,
            Title = artist.Title,
            ReleaseDate = artist.ReleaseDate,
        };
    }
}
