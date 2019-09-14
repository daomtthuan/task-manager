using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;

namespace Task_Manager.Bul.Class
{
    public class Word
    {
        public float ConvertToPoint(double cm)
        {
            return (float)(cm * (72 / 2.54));
        }

        public string ConvertToVietnamese(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday: return "CHỦ NHẬT";
                case DayOfWeek.Monday: return "THỨ HAI";
                case DayOfWeek.Tuesday: return "THỨ BA";
                case DayOfWeek.Wednesday: return "THỨ TƯ";
                case DayOfWeek.Thursday: return "THỨ NĂM";
                case DayOfWeek.Friday: return "THỨ SÁU";
                case DayOfWeek.Saturday: return "THỨ BẢY";
                default: return null;
            }
        }

        public void Write(Range range, string text, float fontsize = 14, int bold = 0, int italic = 0, WdParagraphAlignment alignment = WdParagraphAlignment.wdAlignParagraphJustify, WdUnderline underline = WdUnderline.wdUnderlineNone, float before = 0, float after = 0)
        {
            range.Font.Name = "Times New Roman";
            range.Text = text;
            range.Bold = bold;
            range.Italic = italic;
            range.Underline = underline;
            range.ParagraphFormat.SpaceBefore = before;
            range.ParagraphFormat.SpaceAfter = after;
            range.ParagraphFormat.Alignment = alignment;
            range.Font.Size = fontsize;
        }

        public void PageSetupMargin(Document document, double top = 0, double right = 0, double bottom = 0, double left = 0, double gutter = 0)
        {
            document.PageSetup.TopMargin = ConvertToPoint(top);
            document.PageSetup.RightMargin = ConvertToPoint(right);
            document.PageSetup.BottomMargin = ConvertToPoint(bottom);
            document.PageSetup.LeftMargin = ConvertToPoint(left);
            document.PageSetup.Gutter = ConvertToPoint(gutter);
        }

        public Word(List<Dto.Task> tasks, DateTime dateFrom, DateTime dateTo, string documentPath)
        {
            Application application = new Application();
            Document document = application.Documents.Add();
            PageSetupMargin(document, 2, 1.5, 2, 2, 1);
            document.PageSetup.PaperSize = WdPaperSize.wdPaperA4;

            Range range = document.Range();
            Table table = range.Tables.Add(range, 4, 2);
            table.Columns[1].Width = ConvertToPoint(6);
            table.Columns[2].Width = ConvertToPoint(10.5);

            Write(table.Cell(1, 1).Range, "UBND TP. CẦN THƠ", 12, 0, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(table.Cell(2, 1).Range, "SỞ LAO ĐỘNG", 12, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(table.Cell(3, 1).Range, "THƯƠNG BINH VÀ XÃ HỘI", 12, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(table.Cell(4, 1).Range, "Số:    /LLV-SLĐTBXH", 13, 0, 0, WdParagraphAlignment.wdAlignParagraphCenter, 0, 6);
            Write(table.Cell(1, 2).Range, "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM", 12, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(table.Cell(2, 2).Range, "Độc lập - Tự do - Hạnh phúc", 13, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(table.Cell(4, 2).Range, "Cần Thơ, ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month.ToString("00") + " năm " + DateTime.Now.Year, 13, 0, 1, WdParagraphAlignment.wdAlignParagraphCenter, 0, 6);

            Paragraph head = range.Paragraphs.Add();
            Write(head.Range, "LỊCH LÀM VIỆC\r\n", 14, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter, 0, 12);
            Write(head.Range, "của Ban Lãnh đạo Sở Lao động - Thương binh và Xã hội\r\n", 14, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(head.Range, "thành phố Cần Thơ\r\n", 14, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);
            Write(head.Range, "(Từ " + dateFrom.ToShortDateString() + " đến " + dateTo.ToShortDateString() + ")\r\n", 13, 0, 0, WdParagraphAlignment.wdAlignParagraphCenter, 0, 0, 12);

            Paragraph body = range.Paragraphs.Add();
            int day = -1;
            string content;
            foreach (Dto.Task task in tasks)
            {
                content = "";
                if (day != (int)task.Time.DayOfWeek)
                {
                    day = (int)task.Time.DayOfWeek;
                    Write(body.Range, ConvertToVietnamese(task.Time.DayOfWeek) + ": ngày " + task.Time.ToShortDateString() + "\r\n", 13, 1, 0, WdParagraphAlignment.wdAlignParagraphJustify, 0, 6);
                }
                content += "\t- " + task.Time.Hour.ToString("00") + " giờ " + task.Time.Minute.ToString("00");
                if (task.Content != "")
                {
                    content += " " + task.Content;
                    if (task.RollId != "" && task.RollId != "0") content += (" (đ/c " + task.Name + ", " + task.RollName);
                    else content += (" (" + task.Name);
                    if (task.Note != "") content += " " + task.Note[0].ToString().ToLower() + task.Note.Substring(1) + ").";
                    else content += ").";
                }
                else
                {
                    if (task.RollId != "" && task.RollId != "0") content += (" đ/c " + task.Name + ", " + task.RollName);
                    else content += (" " + task.Name);
                    if (task.Note != "") content += " " + task.Note[0].ToString().ToLower() + task.Note.Substring(1) + ".";
                    else content += ".";
                }
                if (task.Location != "") content += " Địa điểm tại " + task.Location + ".";
                Write(body.Range, content + "\r\n");
            }
            Write(body.Range, "* Ghi chú: Lịch làm việc trên thay thế Giấy mời." + "\r\n", 13, 0, 1, WdParagraphAlignment.wdAlignParagraphJustify, 0, 6, 6);
            Paragraph end = range.Paragraphs.Add();
            Table tableEnd = range.Tables.Add(end.Range, 1, 2);            
            Write(tableEnd.Cell(1, 1).Range, "Nơi nhận:", 12, 1, 1, WdParagraphAlignment.wdAlignParagraphJustify, 0, 6);
            Write(tableEnd.Cell(1, 1).Range.Paragraphs.Add().Range, "- Ban Lãnh đạo Sở\r\n- Các phòng ban, đơn vị\r\ntrực thuộc Sở;\r\n- Lưu: VT, VP.", 11, 0, 1, WdParagraphAlignment.wdAlignParagraphJustify);
            Write(tableEnd.Cell(1, 2).Range, "", 14, 1, 0, WdParagraphAlignment.wdAlignParagraphCenter);

            document.SaveAs(documentPath);
            document.Close();
            application.Quit();

            System.Diagnostics.Process.Start(documentPath);
        }
    }
}