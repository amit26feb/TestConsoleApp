using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Office.Interop;
using System.Reflection;
using System.IO;

namespace FieldExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string functionXMLFile, responseXMLPath, pathToExportFoler;
                Initialize(out functionXMLFile, out responseXMLPath, out pathToExportFoler);

                string responseFilename = "";
                List<ResponseXMLFields> responseFiledXMLList = new List<ResponseXMLFields>();

                //load XML

                XmlDocument doc = new XmlDocument();
                doc.Load(functionXMLFile);

                //read APIsUsed element's value
                XmlNode functionNode = doc.DocumentElement.SelectSingleNode("Preference/Function");
                string APIsUsedAttribute = functionNode.Attributes["APIsUsed"].Value;

                //apis can be one or multiple and comma separated
                string[] listOfApis = APIsUsedAttribute.Split(',');


                //check response of each API from the list

                foreach (string responseAPI in listOfApis)
                {
                    Console.WriteLine(string.Format("Using API {0}", responseAPI));
                    responseFilename = responseXMLPath + @"\Req_" + responseAPI + ".bml.efs";
                    Console.WriteLine(string.Format("Opening {0} file...", responseFilename));
                    XmlDocument responsedoc = new XmlDocument();
                    responsedoc.Load(responseFilename);

                    //Load All Requestfields in the file
                    XmlNodeList responsenodes = responsedoc.DocumentElement.SelectNodes("RequestVersion/RequestField");

                    ProcessEachAPI(responseFiledXMLList, functionNode, responsenodes);

                    //remove duplicates
                    Console.WriteLine("Removing duplicates and sorting...");
                    responseFiledXMLList = responseFiledXMLList.GroupBy(p => p.FieldId).Select(g => g.First()).OrderBy(o => o.FieldId).ToList();

                    string pathToExport = pathToExportFoler + @"\" + responseAPI + ".xlsx";

                    Console.WriteLine(string.Format("Exporting data to excel file at path: {0} ...", pathToExport));
                    WriteToExcel(responseFiledXMLList, pathToExport);

                    //reset responseFiledXMLList
                    responseFiledXMLList = new List<ResponseXMLFields>();

                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Exit();
        }

        /// <summary>
        /// Iterates thru each API and process the efs file
        /// </summary>
        /// <param name="responseFiledXMLList"></param>
        /// <param name="functionNode"></param>
        /// <param name="responsenodes"></param>
        private static void ProcessEachAPI(List<ResponseXMLFields> responseFiledXMLList, XmlNode functionNode, XmlNodeList responsenodes)
        {
            foreach (XmlNode item in responsenodes)
            {
                string fieldId = item.Attributes["FieldID"].Value;
                string displayname = item.Attributes["DisplayName"].Value;
                XmlNodeList fieldNodes = functionNode.SelectNodes("Field");

                //node["FieldId"].Value.Substring(1) removes leading _ or #
                FunctionalXMLField nodes = (from node in fieldNodes.Cast<XmlNode>()
                                            where (!string.IsNullOrEmpty(node.Attributes["FieldId"].Value) && (node.Attributes["FieldId"].Value.Substring(1) == fieldId || node.Attributes["FieldId"].Value.ToLower().Equals(displayname.ToLower())))
                                            select new FunctionalXMLField
                                            {
                                                UiLabel = node.SelectSingleNode("Label").InnerText,
                                                DataTypes = node.Attributes["DataType"].Value,
                                                Format = node.SelectSingleNode("Format").InnerText,
                                                ToolTip = node.SelectSingleNode("Desc").InnerText,
                                                fieldUsage = GetFieldUsageData(node.SelectSingleNode("Usages"))
                                            }).FirstOrDefault() ?? new FunctionalXMLField() { fieldUsage = new Field_Usage() };


                responseFiledXMLList.Add(new ResponseXMLFields
                {
                    FieldId = Int64.Parse(fieldId),
                    DisplayName = displayname,
                    ToolTip = nodes.ToolTip,
                    Format = nodes.Format,
                    DataTypes = nodes.DataTypes,
                    UiLabel = nodes.UiLabel,

                    Type = nodes.fieldUsage.Type,
                    SuppressY_VisibleY = nodes.fieldUsage.SuppressY_VisibleY,
                    SuppressN_VisibleN = nodes.fieldUsage.SuppressN_VisibleN,
                    SuppressN_VisibleY = nodes.fieldUsage.SuppressN_VisibleY,
                    SuppressY_VisibleN = nodes.fieldUsage.SuppressY_VisibleN

                });
            }


        }

        /// <summary>
        /// fetches XML from path Data/Preference/Function/Field/Usages
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <returns></returns>
        private static Field_Usage GetFieldUsageData(XmlNode useXmlNode)
        {
            string suppress = string.Empty;
            string visible = string.Empty;
            string type = string.Empty;
            Field_Usage field_Usage = new Field_Usage();

            //iterates thru each Data/Preference/Function/Field/Usages/Use
            foreach (XmlNode useNode in useXmlNode)
            {
                string attributeValue = string.Empty;
                suppress = useNode.Attributes["Suppress"].Value;
                visible = useNode.Attributes["Visible"].Value;
                type = useNode.Attributes["Type"].Value;
                XmlNodeList attributesNode = useNode.SelectSingleNode("Attributes").ChildNodes;

                //iterates thru each Attribute of Data/Preference/Function/Field/Usages/Use/Attributes
                foreach (XmlNode attribute in attributesNode)
                {
                    string key = attribute.Attributes["Key"].Value;
                    string value = attribute.Attributes["Value"].Value;

                    attributeValue = attributeValue + key + "=" + value + ";";
                }

                if (suppress.Equals("Y") && visible.Equals("Y"))
                    field_Usage.SuppressY_VisibleY = attributeValue;
                else if (suppress.Equals("N") && visible.Equals("N"))
                    field_Usage.SuppressN_VisibleN = attributeValue;
                else if (suppress.Equals("Y") && visible.Equals("N"))
                    field_Usage.SuppressY_VisibleN = attributeValue;
                else
                    field_Usage.SuppressN_VisibleY = attributeValue;

                field_Usage.Type = type;
            }
            return field_Usage;
        }

        /// <summary>
        /// Take All relevant inputs from user
        /// </summary>
        /// <param name="functionXMLFile"></param>
        /// <param name="responseXMLPath"></param>
        /// <param name="pathToExportFoler"></param>
        private static void Initialize(out string functionXMLFile, out string responseXMLPath, out string pathToExportFoler)
        {
            //ask for root path
            //Console.WriteLine("Enter Root path...");
            //string rootPath = Console.ReadLine();
            string rootPath = @"C:\Amit\forAmit";

            //ask for functional XML file 
            Console.WriteLine("Enter functional XML filename...");
            functionXMLFile = Console.ReadLine();

            //  functionXMLFile = "ACTWB.MutualFundsCurrent";

            if (string.IsNullOrEmpty(rootPath) || string.IsNullOrEmpty(functionXMLFile))
            {
                Console.WriteLine("Root Path or filename is blank");
                Exit();
            }

            //user may enter filename with extension or without extension
            if (!functionXMLFile.EndsWith(".xml"))
                functionXMLFile = functionXMLFile + ".xml";

            //user may enter rootpath ending with \
            if (rootPath.EndsWith(@"\") && rootPath.Length > 1)
                rootPath = rootPath.Substring(0, rootPath.Length - 1);



            ////Read response files
            //Console.WriteLine("Enter response XML path...");
            responseXMLPath = rootPath + @"\efs_files";

            //create output folder in root path
            if (!Directory.Exists(rootPath + @"\Output"))
                Directory.CreateDirectory(rootPath + @"\Output");

            //create folder based on input file name. All excel will be stored inside this folder
            pathToExportFoler = rootPath + @"\Output" + @"\" + functionXMLFile;
            if (!Directory.Exists(pathToExportFoler))
                Directory.CreateDirectory(pathToExportFoler);


            functionXMLFile = rootPath + @"\FunctionXML" + @"\" + functionXMLFile;
            Console.WriteLine(string.Format("Opening {0} file...", rootPath));
        }

        /// <summary>
        /// Exits Application
        /// </summary>
        private static void Exit()
        {
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

        private static void WriteToExcel(List<ResponseXMLFields> list, string PathToSave)
        {

            if (string.IsNullOrEmpty(PathToSave))
            {
                throw new Exception("Invalid file path.");
            }
            else if (PathToSave.ToLower().Contains("") == false)
            {
                throw new Exception("Invalid file path.");
            }

            if (list == null)
            {
                throw new Exception("No data to export.");
            }

            Application excelApp = null;
            Workbooks books = null;
            _Workbook book = null;
            Sheets sheets = null;
            _Worksheet sheet = null;
            Range range = null;
            Font font = null;
            // Optional argument variable
            object optionalValue = Missing.Value;

            string strHeaderStart = "A2";
            string strDataStart = "A3";

            int counter = 0;



            try
            {
                #region Init Excel app.


                excelApp = new Application();
                books = (Workbooks)excelApp.Workbooks;
                book = (_Workbook)(books.Add(optionalValue));
                sheets = (Sheets)book.Worksheets;
                sheet = (_Worksheet)(sheets.get_Item(1));

                #endregion

                #region Creating Header


                Dictionary<string, string> objHeaders = new Dictionary<string, string>();

                PropertyInfo[] headerInfo = typeof(ResponseXMLFields).GetProperties();


                foreach (var property in headerInfo)
                {
                    counter++;
                    var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), false)
                                            .Cast<DisplayNameAttribute>().FirstOrDefault();
                    objHeaders.Add(property.Name, attribute == null ?
                                        property.Name : attribute.DisplayName);
                }


                range = sheet.get_Range(strHeaderStart, optionalValue);
                range = range.get_Resize(1, objHeaders.Count);

                range.set_Value(optionalValue, objHeaders.Values.ToArray());
                range.BorderAround(Type.Missing, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, Type.Missing);

                font = range.Font;
                font.Bold = true;
                //  range.Interior.Color = Color.LightGray.ToArgb();

                #endregion

                #region Writing data to cell


                int count = list.Count;
                object[,] objData = new object[count, objHeaders.Count];

                for (int j = 0; j < count; j++)
                {
                    var item = list[j];
                    int i = 0;
                    foreach (KeyValuePair<string, string> entry in objHeaders)
                    {
                        var y = typeof(ResponseXMLFields).InvokeMember(entry.Key.ToString(), BindingFlags.GetProperty, null, item, null);
                        objData[j, i++] = (y == null) ? "" : y.ToString();
                    }
                }


                range = sheet.get_Range(strDataStart, optionalValue);
                range = range.get_Resize(count, objHeaders.Count);

                range.set_Value(optionalValue, objData);
                range.BorderAround(Type.Missing, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, Type.Missing);

                range = sheet.get_Range(strHeaderStart, optionalValue);
                range = range.get_Resize(count + 1, objHeaders.Count);
                range.Columns.AutoFit();

                #endregion

                #region Saving data and Opening Excel file.


                if (string.IsNullOrEmpty(PathToSave) == false)
                    book.SaveAs(PathToSave);

                excelApp.Visible = true;

                #endregion

                #region Release objects

                try
                {
                    if (sheet != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                    sheet = null;

                    if (sheets != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(sheets);
                    sheets = null;

                    if (book != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                    book = null;

                    if (books != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                    books = null;

                    if (excelApp != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }
                catch (Exception ex)
                {
                    sheet = null;
                    sheets = null;
                    book = null;
                    books = null;
                    excelApp = null;
                }
                finally
                {
                    GC.Collect();
                }

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Counter " + counter);
            }

        }


    }
}