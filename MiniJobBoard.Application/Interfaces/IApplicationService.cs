using MiniJobBoard.Application.Models;

namespace MiniJobBoard.Application.Interfaces;

public interface IApplicationService
{
    Task<JobApplicationDto> ApplyAsync(Guid jobId, string applicantUserId, string? coverLetter, CancellationToken ct = default);
}
