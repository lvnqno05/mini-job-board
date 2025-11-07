using MiniJobBoard.Application.Models;

namespace MiniJobBoard.Application.Interfaces;

public interface IJobService
{
    Task<IEnumerable<JobDto>> GetAllAsync(CancellationToken ct = default);
    Task<JobDto?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<JobDto> CreateAsync(string title, string description, Guid employerId, CancellationToken ct = default);
}
