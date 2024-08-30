public abstract class DomainBaseEvents
{
    public DateTime OcurredOn { get; set; }

    public DomainBaseEvents()
    {
        OcurredOn = DateTime.UtcNow;
    }
}
