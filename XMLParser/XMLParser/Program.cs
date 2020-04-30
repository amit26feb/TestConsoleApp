using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Initialize(out string functionXMLFile);

                string responseFilename = "";
                List<ResponseXMLFields> responseFiledXMLList = new List<ResponseXMLFields>();

                //load XML

                XmlDocument doc = new XmlDocument();
                doc.Load(functionXMLFile);


                //read APIsUsed element's value
                //  XmlNodeList functionNode = doc.DocumentElement.SelectNodes("KeyQualifiers/KeyQualifier");
                XmlNodeList functionNode = doc.DocumentElement.SelectNodes("Terms/Term");

                List<string> dataList = new List<string>();
                foreach (XmlNode node in functionNode)
                {
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        //string dataToAdd = "public string " + item.LocalName + " { get; set; }";
                        string dataToAdd = item.LocalName;
                        if (!dataList.Contains(dataToAdd))
                        {
                            dataList.Add(dataToAdd);
                        }
                    }

                }

                foreach (string item in dataList.OrderBy(x => x))
                {
                    //System.Diagnostics.Debug.WriteLine(item);
                    System.Diagnostics.Debug.WriteLine("if (termNode.SelectSingleNode(\"" + item + "\") != null)");
                    System.Diagnostics.Debug.WriteLine("{");
                    System.Diagnostics.Debug.WriteLine("term." + item + " = termNode.SelectSingleNode(\"" + item + "\").FirstChild.Value;");
                    System.Diagnostics.Debug.WriteLine("}");
                }
                Console.ReadLine();
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
                {
                    field_Usage.SuppressY_VisibleY = attributeValue;
                }
                else if (suppress.Equals("N") && visible.Equals("N"))
                {
                    field_Usage.SuppressN_VisibleN = attributeValue;
                }
                else if (suppress.Equals("Y") && visible.Equals("N"))
                {
                    field_Usage.SuppressY_VisibleN = attributeValue;
                }
                else
                {
                    field_Usage.SuppressN_VisibleY = attributeValue;
                }

                field_Usage.Type = type;
            }
            return field_Usage;
        }


        private static void Initialize(out string functionXMLFile)
        {
            //ask for root path
            //Console.WriteLine("Enter Root path...");
            string rootPath = Directory.GetCurrentDirectory();
            //  string rootPath = @"C:\Amit\forAmit";
            Console.WriteLine("Current Folder" + rootPath);
            //ask for functional XML file 
            //  Console.WriteLine("Enter functional XML filename...");
            functionXMLFile = "DataDictionaryInput";

            //  functionXMLFile = "ACTWB.MutualFundsCurrent";

            if (string.IsNullOrEmpty(rootPath) || string.IsNullOrEmpty(functionXMLFile))
            {
                Console.WriteLine("Root Path or filename is blank");
                Exit();
            }

            //user may enter filename with extension or without extension
            if (!functionXMLFile.EndsWith(".xml"))
            {
                functionXMLFile = functionXMLFile + ".xml";
            }

            Console.WriteLine(string.Format("Opening {0} file...", functionXMLFile));
        }

        /// <summary>
        /// Exits Application
        /// </summary>
        private static void Exit()
        {
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }

    }
}