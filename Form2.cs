using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace teste1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=autorack.proxy.rlwy.net;Port=56068;Database=railway;Uid=root;Pwd=vMAGkfLCPCkwdxiTMxfRZEYrOXoWKeBq;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Relatorio_Click_1(object sender, EventArgs e)
        {
            string query = @"
    SELECT ID, Ocorrido, Dano_Fisico, Dano_Material, Setor, Local, Data, Horario 
    FROM dados 
    WHERE 1=1";

            if (!string.IsNullOrEmpty(tx1.Text)) query += " AND Setor = @Setor";
            if (!string.IsNullOrEmpty(tx2.Text)) query += " AND Local = @Local";
            if (!string.IsNullOrEmpty(tx4.Text)) query += " AND Data >= @DataInicial";
            if (!string.IsNullOrEmpty(tx5.Text)) query += " AND Data <= @DataFinal";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Setor", tx1.Text);
                cmd.Parameters.AddWithValue("@Local", tx2.Text);
                cmd.Parameters.AddWithValue("@DataInicial", tx4.Text);
                cmd.Parameters.AddWithValue("@DataFinal", tx5.Text);

                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string chartImagePath = GenerateExcelChartInterop(dt);
                GeneratePDFWithChart(dt, chartImagePath);
            }
        }

        private string GenerateExcelChartInterop(DataTable dt)
        {
            string chartImagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "grafico.png");

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            
            worksheet.Cells[1, 1] = "Setor";
            worksheet.Cells[1, 2] = "Ocorrências";

            var groupedData = dt.AsEnumerable()
                .GroupBy(row => row["Setor"].ToString())
                .Select(g => new
                {
                    Setor = g.Key,
                    Ocorrencias = g.Count()
                }).ToList();

            int excelRow = 2;
            foreach (var data in groupedData)
            {
                worksheet.Cells[excelRow, 1].Value = data.Setor;
                worksheet.Cells[excelRow, 2].Value = data.Ocorrencias;
                excelRow++;
            }

            Excel.ChartObjects chartObjects = worksheet.ChartObjects() as Excel.ChartObjects;
            Excel.ChartObject chartObject = chartObjects.Add(Left: 100, Width: 500, Top: 50, Height: 300);
            Excel.Chart chart = chartObject.Chart;

            Excel.Range dataRange = worksheet.Range["A1:B" + (excelRow - 1)];
            chart.SetSourceData(dataRange);
            chart.ChartType = Excel.XlChartType.xlColumnClustered;

            chart.Export(chartImagePath, "PNG");

            workbook.Close(false);
            excelApp.Quit();

            Marshal.ReleaseComObject(chart);
            Marshal.ReleaseComObject(chartObjects);
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);

            return chartImagePath;
        }

        private void GeneratePDFWithChart(DataTable dt, string chartImagePath)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfFilePath = Path.Combine(desktopPath, "relatorio_com_grafico.pdf");

            Document doc = new Document();
            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                doc.Add(new Paragraph("Relatório de Ocorrências"));
                doc.Add(new Paragraph("Data de Geração: " + DateTime.Now.ToString("dd/MM/yyyy")));

                if (File.Exists(chartImagePath))
                {
                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImagePath);
                    chartImage.ScaleToFit(500f, 300f);
                    chartImage.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    doc.Add(chartImage);
                }

                doc.Add(new Paragraph("\n"));

                doc.Add(new Paragraph("Resumo do Gráfico:"));
                var groupedData = dt.AsEnumerable()
                    .GroupBy(row => row["Setor"].ToString())
                    .Select(g => new
                    {
                        Setor = g.Key,
                        Ocorrencias = g.Count(),
                        IDs = string.Join(", ", g.Select(r => r["ID"].ToString()))
                    });

                foreach (var data in groupedData)
                {
                    doc.Add(new Paragraph($"Setor: {data.Setor}, Ocorrências: {data.Ocorrencias}, IDs: {data.IDs}"));
                    doc.Add(new Paragraph("\n"));
                }

                doc.Add(new Paragraph("\n"));

             
                PdfPTable table = new PdfPTable(dt.Columns.Count + 1 - 1);

                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName != "Texto")
                    {
                        table.AddCell(column.ColumnName); 
                    }
                }

                
                foreach (DataRow pdfRow in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.ColumnName != "Texto")
                        {
                            table.AddCell(pdfRow[column].ToString()); 
                        }
                    }
                }

               
                doc.Add(table);

                doc.Close();
            }

            MessageBox.Show("Relatório gerado com sucesso na área de trabalho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
