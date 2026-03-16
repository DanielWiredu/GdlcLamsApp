namespace LAMS.Server.Services
{
    using ClosedXML.Excel;
    using Microsoft.JSInterop;
    using System.Reflection;
    using System.Text;

    public class ExportService : IExportService
    {
        private readonly IJSRuntime _js;
        public ExportService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task ExportToExcel<T>(IEnumerable<T> data, string fileName)
        {
            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Data");

            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Header
            for (int i = 0; i < props.Length; i++)
            {
                ws.Cell(1, i + 1).Value = props[i].Name;
                ws.Cell(1, i + 1).Style.Font.Bold = true;
            }

            // Rows
            int row = 2;
            foreach (var item in data)
            {
                for (int col = 0; col < props.Length; col++)
                {
                    var val = props[col].GetValue(item);
                    var cell = ws.Cell(row, col + 1);

                    if (val == null)
                    {
                        cell.Value = "";
                    }
                    else if (val is DateTime dt)
                    {
                        cell.Value = dt;
                        cell.Style.DateFormat.Format = "dd-MMM-yyyy";
                    }
                    else if (val is bool b)
                    {
                        cell.Value = b ? "Yes" : "No";
                    }
                    else if (val is int or long or double or decimal or float)
                    {
                        cell.Value = Convert.ToDouble(val);
                    }
                    else
                    {
                        cell.Value = val.ToString();
                    }
                }

                row++;
            }

            //ws.Columns().AdjustToContents();

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);

            stream.Position = 0;  

            var bytes = stream.ToArray();

            await DownloadFile(
                fileName,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                bytes);

        }

        public async Task ExportToCsv<T>(IEnumerable<T> data, string fileName)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var sb = new StringBuilder();

            // Header
            sb.AppendLine(string.Join(",", props.Select(p => p.Name)));

            // Rows
            foreach (var item in data)
            {
                var values = props.Select(p =>
                {
                    var raw = p.GetValue(item);
                    var val = raw?.ToString()?.Replace("\"", "\"\"").Replace("\r", "").Replace("\n", " ") ?? "";
                    return $"\"{val}\"";
                });

                sb.AppendLine(string.Join(",", values));
            }

            var csv = sb.ToString();
            var bytes = Encoding.UTF8.GetPreamble()
                .Concat(Encoding.UTF8.GetBytes(csv))
                .ToArray();

            await DownloadFile(fileName, "text/csv;charset=utf-8", bytes);
        }
        private async Task DownloadFile(string fileName, string contentType, byte[] bytes)
        {
            using var stream = new MemoryStream(bytes);
            using var streamRef = new DotNetStreamReference(stream);

            await _js.InvokeVoidAsync(
                "downloadFileFromStream",
                fileName,
                streamRef);
        }
    }

}
