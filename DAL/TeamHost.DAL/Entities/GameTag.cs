﻿namespace TeamHost.DAL.Entities
{
    public class GameTag : BaseEntity
    {
        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}
