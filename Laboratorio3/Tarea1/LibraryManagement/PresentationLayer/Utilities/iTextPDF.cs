using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = iText.Kernel.Colors.Color;

namespace PresentationLayer.Utilities
{
    public class iTextPDF
    {
        public Document IniatializePDF(string path)
        {
            PdfWriter pdfWriter = new PdfWriter(path);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);

            return document;
        }

        public Paragraph GenerateHeaderPDF(string header)
        {
            Paragraph paragraph = new Paragraph(header);

            paragraph
                .SetFontSize(16)
                .SetFontColor(ColorConstants.BLUE)
                .SetTextAlignment(TextAlignment.CENTER);
            return paragraph;
        }

        public Paragraph GenerateHeaderPDF(string header, int fontSize)
        {
            Paragraph paragraph = new Paragraph(header);

            paragraph
                .SetFontSize(fontSize)
                .SetFontColor(ColorConstants.BLUE)
                .SetTextAlignment(TextAlignment.CENTER);
            return paragraph;
        }
        
        public Paragraph GenerateHeaderPDF(string header, int fontSize, Color color)
        {
            Paragraph paragraph = new Paragraph(header);

            paragraph
                .SetFontSize(fontSize)
                .SetFontColor(color)
                .SetTextAlignment(TextAlignment.CENTER);
            return paragraph;
        }

        public Table GenerateTablePDF(int columns, DataGridView dataGridView)
        {
            Table table = new Table(columns).UseAllAvailableWidth();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Cell cell = new Cell();
                cell.SetFontSize(11)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(column.HeaderText.ToUpper()));
                table.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell dataGridViewCell in row.Cells)
                {
                    if (dataGridViewCell != null)
                    {
                        table.AddCell(dataGridViewCell.Value.ToString());
                    }
                }
            }
            return table;
        }
    }
}