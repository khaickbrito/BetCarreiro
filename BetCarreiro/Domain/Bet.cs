namespace BetCarreiro.Domain;

public class Bet
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; private set; }

    public Guid EventId { get; private set; }

    public string Team { get; private set; }

    public double BetValue { get; private set; }

    public bool Result { get; private set; }

    public DateTime InclusionDate { get; private set; }

    public Bet(Guid customerId, Guid eventId, string team, double betValue, DateTime inclusionDate)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        EventId = eventId;
        Team = team;
        BetValue = betValue;
    }
}
    
