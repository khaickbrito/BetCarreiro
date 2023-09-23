namespace BetCarreiro.Domain
{
    public class Event
    {
        public Guid Id { get; private set; }
        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public double OddTeam1 { get; private set; }
        public double OddTeam2 { get;}
        public DateTime InclusionDate { get; private set; }
        public bool IsFinished { get; set; }

        public Event(string team1, string team2, double oddTeam1, double oddTeam2)
        {
            Id = Guid.NewGuid();
            Team1 = team1;
            Team2 = team2;
            OddTeam1 = oddTeam1;
            OddTeam2 = oddTeam2;
            InclusionDate = DateTime.Now;
        }
    }
}
