namespace Cafeteria.Contracts.Contracts;
public record CardapioResponse(
    string name,
    string description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
    );
