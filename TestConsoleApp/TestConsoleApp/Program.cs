using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.FileIO;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsIdentity winId = WindowsIdentity.GetCurrent();
            Console.WriteLine(winId.Name);
            //int x = 8;
            //int y = 16;
            //int z = 64;

            //  x /= y /= z;

            //double a = 345.09;
            //byte c = (byte)a;

            //string a = "Amit";

            //foreach (char item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //int testCases = 1;

            //string sentence = "We love to hack on hackerearth";
            //string word = " hack ";

            //string YorN = "N";

            //int pos = 14;

            //for (int i = 0; i < testCases; i++)
            //{
            //    if (YorN == "N")
            //    {
            //        if (sentence.Substring(pos).Contains(word))
            //        {
            //            Console.WriteLine(sentence.Substring(pos).IndexOf(word));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Goodbye Watson.");
            //        }
            //    }
            //    else
            //    {
            //        if (sentence.Substring(pos).ToLower().StartsWith(word.ToLower() + " "))
            //        {
            //            Console.WriteLine(pos);
            //        }
            //        else if (sentence.Substring(pos).ToLower().EndsWith(" " + word.ToLower()))
            //        {
            //            Console.WriteLine(sentence.Substring(pos).IndexOf(" " + word.ToLower()));
            //        }
            //        else if (sentence.Substring(pos).ToLower().Contains(" " + word.ToLower() + " "))
            //        {
            //            Console.WriteLine(sentence.Substring(pos).IndexOf(" " + word.ToLower() + " ") + 1);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Goodbye Watson.");
            //        }
            //    }
            //}

            //  Console.WriteLine(x +" "+y+" "+z);
            //double d = -10000.79;
            //Console.WriteLine(d);
            //decimal d1 = decimal.Parse(d.ToString());

            //Console.WriteLine(d1.ToString("$#,0.00"));
            //string s = "72090";

            //foreach (char item in s.ToArray())
            //{
            //    Console.WriteLine(item);
            //}
            // Console.WriteLine();
            // GridColWidth();
            // dtoGen();
            //string[] a  = Directory.GetFiles(@"C:\Amit\Code\Betalink\ModelRebalanceTrading.API\src\ModelRebalanceTrading.API\bin\Debug\netcoreapp3.1");
            //List<string> s = new List<string>();
            //foreach (var item in a)
            //{
            //    if((item.EndsWith(".dll") || item.EndsWith(".pdb")) && !item.Contains("Microsoft.") )
            //    s.Add(item);
            //}

            //File.WriteAllLines(@"C:\Amit\Code\Betalink\ModelRebalanceTrading.API\src\ModelRebalanceTrading.API\bin\Debug\netcoreapp3.1\FileName.txt", a);
            //OpenXmlExcelExport();

            // decimal value = -144.64m;
            // Console.WriteLine("Your account balance is {0:C2}.", value);

            //DateTime chotaDt = DateTime.Now;
            //DateTime badaDt = DateTime.Now.AddHours(1);

            //Console.WriteLine(chotaDt.TimeOfDay.CompareTo(badaDt.TimeOfDay));
            //Console.WriteLine(badaDt.Subtract(chotaDt));

            //Console.WriteLine(string.Format("{0:pn}","20"));
            //string a = File.ReadAllText(@"./BETA.Translations.json");

            //var b = JsonConvert.DeserializeObject<Class1[]>(a);

            //var c = b;
            //Decimal.TryParse("56.09", out decimal d);
            //Rootobject a = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(@"C:\Amit\Docs\Reng_B.json"));

            //List<Behaviorterm[]> i = a.data.behaviorQualifier.Select(x=>x.behaviorTerms).ToList();

            //string qty = Decimal.Truncate(d).ToString();
            //Console.WriteLine(qty);
            //string name = null;
            //switch (name)
            //{
            //    default:
            //        name = "default";
            //        break;
            //}
            //Console.WriteLine(name);
            //List<TestList> list = new List<TestList>
            //{
            //    new TestList { col1 = "B", col2 = "" },
            //    new TestList { col1 = "C", col2 = "B" },
            //    new TestList { col1 = "D", col2 = "C" },
            //    new TestList { col1 = "E", col2 = "D" },
            //    new TestList { col1 = "F", col2 = "E" }
            //};

            //var a = list.FirstOrDefault(x => !x.col2.Contains(x.col1));
            //var color = (Color)ColorConverter.ConvertFromString("Red");

            //TestList t = new TestList();
            //try
            //{

            //    t.col1 = "'huh";
            //    t.col1.AssignError("mera err");
            //    Console.WriteLine(t.col1);
            //    Console.WriteLine(t.col2);
            //    throw new ArgumentNullException();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("exception");
            //    Console.WriteLine(t.col1);
            //}

            //  Console.WriteLine(a);

            Console.ReadLine();
        }

        private static void OpenXmlExcelExport()
        {
            string xlsx_path = @"c:\Temp\test.xlsx";
            string CSV_Path = @"C:\Temp\test.csv";

            // Skal nok ha en try her i tilfellet et dolument er åpent eller noe slikt...
            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(xlsx_path, SpreadsheetDocumentType.Workbook))
            {
                spreadsheet.AddWorkbookPart();
                spreadsheet.WorkbookPart.Workbook = new Workbook();
                WorksheetPart wsPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                wsPart.Worksheet = new Worksheet();
                SheetFormatProperties sheetFormatProperties = new SheetFormatProperties()
                {
                    DefaultColumnWidth = 15,
                    DefaultRowHeight = 15D
                };

                wsPart.Worksheet.Append(sheetFormatProperties);
                WorkbookStylesPart stylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>();
                stylesPart.Stylesheet = new Stylesheet();

                // Font list
                // Create a bold font
                stylesPart.Stylesheet.Fonts = new Fonts();
                Font bold_font = new Font();         // Bold font
                Bold bold = new Bold();
                bold_font.Append(bold);

                // Add fonts to list
                stylesPart.Stylesheet.Fonts.AppendChild(new Font());
                stylesPart.Stylesheet.Fonts.AppendChild(bold_font); // Bold gets fontid = 1
                stylesPart.Stylesheet.Fonts.Count = 2;

                // Create fills list
                stylesPart.Stylesheet.Fills = new Fills();

                // create red fill for failed tests
                PatternFill formatRed = new PatternFill() { PatternType = PatternValues.Solid };
                formatRed.ForegroundColor = new ForegroundColor { Rgb = HexBinaryValue.FromString("FF6600") }; // red fill
                formatRed.BackgroundColor = new BackgroundColor { Indexed = 64 };

                // Create green fill for passed tests
                PatternFill formatGreen = new PatternFill() { PatternType = PatternValues.Solid };
                formatGreen.ForegroundColor = new ForegroundColor { Rgb = HexBinaryValue.FromString("99CC00") }; // green fill
                formatGreen.BackgroundColor = new BackgroundColor { Indexed = 64 };

                // Create blue fill
                PatternFill formatBlue = new PatternFill() { PatternType = PatternValues.Solid };
                formatBlue.ForegroundColor = new ForegroundColor { Rgb = HexBinaryValue.FromString("81DAF5") };
                formatBlue.BackgroundColor = new BackgroundColor { Indexed = 64 };

                // Create Light Green fill
                PatternFill formatLightGreen = new PatternFill() { PatternType = PatternValues.Solid };
                formatLightGreen.ForegroundColor = new ForegroundColor { Rgb = HexBinaryValue.FromString("F1F8E0") };
                formatLightGreen.BackgroundColor = new BackgroundColor { Indexed = 64 };

                // Append fills to list
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = new PatternFill { PatternType = PatternValues.None } }); // required, reserved by Excel
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = new PatternFill { PatternType = PatternValues.Gray125 } }); // required, reserved by Excel
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = formatRed }); // Red gets fillid = 2
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = formatGreen }); // Green gets fillid = 3
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = formatBlue }); // Blue gets fillid = 4, old format1
                stylesPart.Stylesheet.Fills.AppendChild(new Fill { PatternFill = formatLightGreen }); // LightGreen gets fillid = 5, old format2
                stylesPart.Stylesheet.Fills.Count = 6;

                // Create border list
                stylesPart.Stylesheet.Borders = new Borders();

                // Create thin borders for passed/failed tests and default cells
                LeftBorder leftThin = new LeftBorder() { Style = BorderStyleValues.Thin };
                RightBorder rightThin = new RightBorder() { Style = BorderStyleValues.Thin };
                TopBorder topThin = new TopBorder() { Style = BorderStyleValues.Thin };
                BottomBorder bottomThin = new BottomBorder() { Style = BorderStyleValues.Thin };

                Border borderThin = new Border();
                borderThin.Append(leftThin);
                borderThin.Append(rightThin);
                borderThin.Append(topThin);
                borderThin.Append(bottomThin);

                // Create thick borders for headings
                LeftBorder leftThick = new LeftBorder() { Style = BorderStyleValues.Thick };
                RightBorder rightThick = new RightBorder() { Style = BorderStyleValues.Thick };
                TopBorder topThick = new TopBorder() { Style = BorderStyleValues.Thick };
                BottomBorder bottomThick = new BottomBorder() { Style = BorderStyleValues.Thick };

                Border borderThick = new Border();
                borderThick.Append(leftThick);
                borderThick.Append(rightThick);
                borderThick.Append(topThick);
                borderThick.Append(bottomThick);

                // Add borders to list
                stylesPart.Stylesheet.Borders.AppendChild(new Border());
                stylesPart.Stylesheet.Borders.AppendChild(borderThin);
                stylesPart.Stylesheet.Borders.AppendChild(borderThick);
                stylesPart.Stylesheet.Borders.Count = 3;

                // Create blank cell format list
                stylesPart.Stylesheet.CellStyleFormats = new CellStyleFormats();
                stylesPart.Stylesheet.CellStyleFormats.Count = 1;
                stylesPart.Stylesheet.CellStyleFormats.AppendChild(new CellFormat());

                // Create cell format list
                stylesPart.Stylesheet.CellFormats = new CellFormats();
                // empty one for index 0, seems to be required
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat());


                // cell format for failed tests, Styleindex = 1, Red fill and bold text
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat { FormatId = 0, FontId = 1, BorderId = 2, FillId = 2, ApplyFill = true }).AppendChild(new Alignment { Horizontal = HorizontalAlignmentValues.Center });

                // cell format for passed tests, Styleindex = 2, Green fill and bold text
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat { FormatId = 0, FontId = 1, BorderId = 2, FillId = 3, ApplyFill = true }).AppendChild(new Alignment { Horizontal = HorizontalAlignmentValues.Center });

                // cell format for blue background, Styleindex = 3, blue fill and bold text
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat { FormatId = 0, FontId = 1, BorderId = 1, FillId = 4, ApplyFill = true }).AppendChild(new Alignment { Horizontal = HorizontalAlignmentValues.Center });

                // cell format for light green background, Styleindex = 4, light green fill and bold text
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat { FormatId = 0, FontId = 1, BorderId = 1, FillId = 5, ApplyFill = true }).AppendChild(new Alignment { Horizontal = HorizontalAlignmentValues.Center });

                // default cell style, thin border and rest default
                stylesPart.Stylesheet.CellFormats.AppendChild(new CellFormat { FormatId = 0, FontId = 0, BorderId = 1, FillId = 0, ApplyFill = true }).AppendChild(new Alignment { Horizontal = HorizontalAlignmentValues.Center });

                stylesPart.Stylesheet.CellFormats.Count = 6;
                stylesPart.Stylesheet.Save();

                Columns columns = new Columns();

                columns.Append(new Column() { Min = 1, Max = 3, Width = 20, CustomWidth = true });
                columns.Append(new Column() { Min = 4, Max = 4, Width = 30, CustomWidth = true });

                wsPart.Worksheet.Append(columns);


                SheetData sheetData = wsPart.Worksheet.AppendChild(new SheetData());
                TextFieldParser parser = new TextFieldParser(CSV_Path);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    string line = parser.ReadLine();
                    string[] elements = line.Split(';');
                    Row row = sheetData.AppendChild(new Row());
                    if (parser.LineNumber == 2)
                    {
                        foreach (string element in elements)
                        {
                            row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 3 });
                        }
                    }
                    if (parser.LineNumber == 3)
                    {
                        foreach (string element in elements)
                        {
                            if (elements.First() == element && element == "Pass")
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 2 });
                            }
                            else if (elements.First() == element && element == "Fail")
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 1 });
                            }
                            else
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 5 });
                            }
                        }
                    }
                    if (parser.LineNumber == 4)
                    {
                        foreach (string element in elements)
                        {
                            row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 4 });
                        }
                    }
                    if (parser.LineNumber > 4 || parser.LineNumber == -1)
                    {
                        int i = 0;
                        foreach (string element in elements)
                        {
                            if (i == 1 && element == "Pass")
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 2 });
                            }
                            else if (i == 1 && element == "Fail")
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 1 });
                            }
                            else
                            {
                                row.AppendChild(new Cell() { CellValue = new CellValue(element), DataType = CellValues.String, StyleIndex = 5 });
                            }
                            i++;
                        }
                    }
                }
                Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild(new Sheets());
                sheets.AppendChild(new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(wsPart), SheetId = 1, Name = "sheet1" });
                spreadsheet.WorkbookPart.Workbook.Save();
            }
        }

        private static void dtoGen()
        {
            List<string> l = new List<string>() { "qty_ind",
"offset_type",
"offset_account",
"broker_no",
"apr_actionuser",
"Apr_firstname",
"apr_Lastname",
"user_timestamp",

};
            foreach (string item in l)
            {
                Console.WriteLine("[HostField(\"" + item.ToUpper() + "\")]");
                Console.WriteLine("[JsonProperty(PropertyName = \"" + item.ToLower() + "\")]");
                Console.WriteLine("public string " + item.ToUpper() + " { get; set; }");


                Console.WriteLine();
            }
        }

        private static void GridColWidth()
        {
            List<string> l = new List<string>() { "orderPendBranch",
"actionDate",
"actionTime",
"actionUserId",
"actionReason",
"orderAction",



};
            List<string> r = new List<string>();

            foreach (string str in l)
            {
                r.Add(Char.ToUpperInvariant(str[0]) + str.Substring(1).Trim());
            }
            foreach (string str in r)
            {
                Console.WriteLine("\"" + str + "\"");
            }
        }
    }
    class TestList
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
    }
    public static class Extensions
    {
        public static void AssignError(this String field, string errorMessage)
        {
            if (!string.IsNullOrEmpty(field))
            {
                field = string.Concat(field, "\n", errorMessage);

            }
            else
            {
                field = errorMessage;

            }
        }
    }
}
