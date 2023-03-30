using MelodiusModels;

namespace MelodiusDataTransfer.Mappers
{
    public class PlaylistMapper
    {
        public static Playlist DtoToModel(PlaylistDto artistDto)
        => new Playlist()
        {
            Id = artistDto.Id,
            Title = artistDto.Title,
            Description = artistDto.Description,
        };

        public static PlaylistDto ModelToDto(Playlist artist)
        => new PlaylistDto()
        {
            Id = artist.Id,
            Title = artist.Title,
            Description = artist.Description,
        };
    }
}
