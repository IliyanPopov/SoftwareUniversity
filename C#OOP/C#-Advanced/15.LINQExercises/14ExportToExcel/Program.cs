namespace _14ExportToExcel
{
    using System.Drawing;
    using System.IO;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    public class Program
    {
        public static void Main()
        {
            ExcelPackage exelPackage = new ExcelPackage();
            ExcelWorksheet workSheet = exelPackage.Workbook.Worksheets.Add("SoftUni");

            workSheet.Cells[1, 1, 1, 11].Merge = true;
            workSheet.Cells[1, 1, 1, 11].Style.Font.Size = 18;
            workSheet.Cells[1, 1, 1, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells[1, 1].Value = "Softuni OOP Results";

            //fill first row with green color
            for (int i = 1; i <= 11; i++)
            {
                var fill = workSheet.Cells[2, i].Style.Fill;
                fill.PatternType = ExcelFillStyle.Solid;
                fill.BackgroundColor.SetColor(Color.Green);
            }

            // read words from file
            using (StreamReader reader = new StreamReader("StudentData.txt"))
            {
                string line = reader.ReadLine();
                var row = 2;

                while (line != null)
                {
                    var columns = line.Split('\t');
                    for (int i = 1; i <= columns.Length; i++)
                    {
                        workSheet.Cells[row, i].Value = columns[i - 1];
                    }
                    row++;
                    line = reader.ReadLine();
                }
            }

            exelPackage.SaveAs(new FileInfo(@"E:\New2.xlsx"));
        }
    }
}