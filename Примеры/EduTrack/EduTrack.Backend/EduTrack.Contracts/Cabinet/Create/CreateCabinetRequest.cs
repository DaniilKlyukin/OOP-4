namespace EduTrack.Contracts.Cabinet.Create;

public record CreateCabinetRequest(
    string Building,
    string Audience,
    string? Description);