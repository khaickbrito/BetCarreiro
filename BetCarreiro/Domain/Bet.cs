namespace BetCarreiro.Domain;

public class Bet
{
    public Guid Id { get; private set; }

    public Guid CustomerId { get; private set; }

    public Guid EventId { get; private set; }

    public double Team { get; private set; }

    public double BetValue { get; private set; }

    public bool Result { get; private set; }

    public DateTime InclusionDate { get; private set; }

    public Bet(Guid customerId, Guid eventId, double team, double betValue)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        EventId = eventId;
        Team = team;
        BetValue = betValue;
    }
}
