using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldExtractor
{
    /// <summary>
    /// Used to create a simple list and export as it is to excel sheet
    /// </summary>
    public class ResponseXMLFields : FunctionalXMLField
    {
        public Int64 FieldId { get; set; }
        public string DisplayName { get; set; }


    }
}
