using CoreAbstractions.Entities;
using System;
using System.Threading.Tasks;

namespace ServerAbstractions.Services
{
    public interface IReportService
    {
        Task<ReportMetadata> GetAsync(Guid reportId);
    }
}
