namespace ACME.OOP.SCM.Domain.Model.ValueObjects;

public record SupplierId
{
    public string Identifier { get; init; }

    public SupplierId(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
        throw new ArgumentNullException("SupplierId cannot be null or emppty", nameof(identifier));
        Identifier = identifier;    
    }
}