using MelodiusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTransfer.Mappers
{
    public class ArtistMapper
    {
        public static Artist DtoToModel(ArtistDto artistDto)
        => new Artist()
        {
            Id = artistDto.Id,
            ArtistName = artistDto.ArtistName,
            Biography = artistDto.Biography,
        };

        public static ArtistDto ModelToDto(Artist artist)
        => new ArtistDto()
        {
            Id = artist.Id,
            ArtistName = artist.ArtistName,
            Biography = artist.Biography,
        };
    }
}
