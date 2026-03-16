namespace LAMS.Server.Services
{
    public interface IExportService
    {
        Task ExportToExcel<T>(IEnumerable<T> data, string fileName);
        Task ExportToCsv<T>(IEnumerable<T> data, string fileName);
    }
}
