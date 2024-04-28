using ClosedXML.Excel;

namespace FiresWinForms
{
    public static class XlsSaver
    {
        public static bool fileCreated = false;
        public static string dataPath = "Data\\data.xlsx";

        public static void SaveData(List<DataModel> data, int measurement)
        {
            var workbook = fileCreated ? new XLWorkbook(dataPath) : new XLWorkbook();
            var worksheetName = "Meranie " + measurement;
            bool worksheetExists = workbook.Worksheets.Contains(worksheetName);
            if (worksheetExists)
            {
                workbook.Worksheet(worksheetName).Delete();
            }
            var worksheet = workbook.Worksheets.Add(worksheetName);

            worksheet.Cell("A1").Value = "Čas (s)";
            worksheet.Cell("B1").Value = "Sila (N)";

            for (int i = 0; i < data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data[i].Time;
                worksheet.Cell(i + 2, 2).Value = data[i].Value;
            }

            workbook.SaveAs(dataPath);
            fileCreated = true;
        }
    }
}
