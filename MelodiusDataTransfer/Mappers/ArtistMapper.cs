using MelodiusModels;

namespace MelodiusDataTransfer.Mappers
{
    public static class ArtistMapper
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
