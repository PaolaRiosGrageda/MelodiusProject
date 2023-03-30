using MelodiusModels;

namespace MelodiusDataTransfer.Mappers
{
    public static class AlbumMapper
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
