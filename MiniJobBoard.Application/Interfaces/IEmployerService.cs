using MiniJobBoard.Application.Models;

namespace MiniJobBoard.Application.Interfaces;

public interface IEmployerService
{
    Task<EmployerDto> CreateEmployerAsync(string companyName, string? contactName, CancellationToken ct = default);
    Task<EmployerDto?> GetByIdAsync(Guid id, CancellationToken ct = default);
}
