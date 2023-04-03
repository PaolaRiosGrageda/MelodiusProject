﻿using MelodiusModels.Base;

namespace MelodiusModels
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<UserPlayList>? UserPlayList { get; set; }
    }
}