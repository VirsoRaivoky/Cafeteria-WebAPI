namespace Cafeteria.Contracts.Contracts;
public record CreateCardapioRequest(
    string name,
    string description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
    );
