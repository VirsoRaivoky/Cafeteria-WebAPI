namespace Cafeteria.Contracts.Contracts;
public record UpsertCardapioRequest(
    string name,
    string description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
    );
