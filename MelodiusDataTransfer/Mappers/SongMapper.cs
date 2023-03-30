using MelodiusModels;


namespace MelodiusDataTransfer.Mappers
{
    public static class SongMapper
    {
        public static Song DtoToModel(SongDto songDto)
        => new Song()
        {
            Id= songDto.Id,
            Title= songDto.Title,
            ReleaseDate= songDto.ReleaseDate,
            Length= songDto.Length,
            Genre= songDto.Genre,

        };
        public static SongDto ModelToDto(Song song)
        {
            return new SongDto()
            {
                Id = song.Id,
                Title = song.Title,
                ReleaseDate = song.ReleaseDate,
                Length = song.Length,
                Genre = song.Genre,

            };

        }
    }
}
