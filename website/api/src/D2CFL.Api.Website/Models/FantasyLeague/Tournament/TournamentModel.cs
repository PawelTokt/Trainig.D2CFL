﻿using System;

namespace D2CFL.Api.Website.Models.FantasyLeague.Tournament
{
    public class TournamentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
