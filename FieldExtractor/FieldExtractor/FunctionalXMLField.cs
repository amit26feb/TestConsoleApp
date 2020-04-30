using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldExtractor
{
    /// <summary>
    /// used to read data from the functionXML e.g. RepWB.Header.XML
    /// </summary>
    public class FunctionalXMLField : Field_Usage
    {
        public Field_Usage fieldUsage;

        public string DataTypes { get; set; }

        public string UiLabel { get; set; }

        public string Format { get; set; }

        public string ToolTip { get; set; }

    }

    public class Field_Usage
    {
        public string Type { get; set; }
        public string SuppressY_VisibleY { get; set; }
        public string SuppressN_VisibleN { get; set; }
        public string SuppressN_VisibleY { get; set; }
        public string SuppressY_VisibleN { get; set; }

        
    }
}
