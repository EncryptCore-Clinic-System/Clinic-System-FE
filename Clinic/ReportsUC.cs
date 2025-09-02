using Clinic.Models;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            using (var context = new MyContext())
            {
                var patients = context.Patients.ToList();

                if (patients.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF Documents (*.pdf)|*.pdf";
                    sfd.FileName = "patients.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Create PDF file
                            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();

                            // Title
                            Paragraph title = new Paragraph("Patients Report",
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK));
                            title.Alignment = Element.ALIGN_CENTER;
                            doc.Add(title);
                            doc.Add(new Paragraph("\n"));

                            // Create table with 4 columns
                            PdfPTable table = new PdfPTable(8);
                            table.WidthPercentage = 100;

                            // Add headers
                            table.AddCell("ID");
                            table.AddCell("Name");
                            table.AddCell("Age");
                            table.AddCell("Gender");
                            table.AddCell("Phone");
                            table.AddCell("Address");
                            table.AddCell("Medical Hestory");
                            table.AddCell("Created Date");


                            // Add rows
                            foreach (var p in patients)
                            {
                                table.AddCell(p.PatientID.ToString());
                                table.AddCell(p.Name);
                                table.AddCell(p.Age.ToString());
                                table.AddCell(p.Gender);
                                table.AddCell(p.Phone);
                                table.AddCell(p.Address);
                                table.AddCell(p.MedicalHistory);
                                table.AddCell(p.CreatedAt.ToString("yyyy-MM-dd"));

                            }

                            doc.Add(table);
                            doc.Close();

                            MessageBox.Show("Export to PDF Successful");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data to export");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            using (var context = new MyContext())
            {
                var patients = context.Patients.ToList();

                if (patients.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                    sfd.FileName = "patients.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Patients");

                            // Write header
                            worksheet.Cell(1, 1).Value = "ID";
                            worksheet.Cell(1, 2).Value = "Name";
                            worksheet.Cell(1, 3).Value = "Age";
                            worksheet.Cell(1, 4).Value = "Gender";
                            worksheet.Cell(1, 5).Value = "Phone";
                            worksheet.Cell(1, 6).Value = "Address";
                            worksheet.Cell(1, 7).Value = "Medical Hestory";
                            worksheet.Cell(1, 8).Value = "Created Date";


                            // Write data
                            int row = 2;
                            foreach (var p in patients)
                            {
                                worksheet.Cell(row, 1).Value = p.PatientID;
                                worksheet.Cell(row, 2).Value = p.Name;
                                worksheet.Cell(row, 3).Value = p.Age;
                                worksheet.Cell(row, 4).Value = p.Gender;
                                worksheet.Cell(row, 5).Value = p.Phone;
                                worksheet.Cell(row, 6).Value = p.Address;
                                worksheet.Cell(row, 7).Value = p.MedicalHistory;
                                worksheet.Cell(row, 8).Value = p.CreatedAt.ToString("yyyy-MM-dd");

                                row++;
                            }

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Export to Excel Successful");
                    }
                }
                else
                {
                    MessageBox.Show("No data to export");
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            DataGridView.EnableHeadersVisualStyles = false; 
        }
    }
}
