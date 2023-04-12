namespace MelodiusDataTransfer.Requests
{
    public class CompletePlaylistRequest
    {
        public PlaylistDto Playlist { get; set; }
        public int UserId { get; set; }
        public List<int> SongsIds { get; set; }

    }
}
