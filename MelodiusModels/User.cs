using MelodiusModels.Base;

namespace MelodiusModels
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    }
}