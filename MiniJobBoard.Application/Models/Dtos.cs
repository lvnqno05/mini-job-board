namespace MiniJobBoard.Application.Models;

public record EmployerDto(Guid Id, string CompanyName, string? ContactName);
public record JobDto(Guid Id, string Title, string Description, Guid EmployerId, string EmployerName, DateTime CreatedAt);
public record JobApplicationDto(Guid Id, Guid JobId, string ApplicantUserId, string? CoverLetter, DateTime AppliedAt);
