using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates;

public class Supplier(string identifier, string name, Address address)
{
    public string Identifier { get; set; } = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));
    public Address Address { get; set; } = address ?? throw new ArgumentNullException(nameof(address));
}