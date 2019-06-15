using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCITable type is used in responses only, never in requests.
    /// The table consists of rows and columns of strings. Each column has a column
    /// heading. Clients should search the column headings to find a particular
    /// column. Clients should not assume any particular column order as future
    /// revisions of the protocol may move or add columns.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
     
    public class OCITable 
    {

        
        private List<string> _colHeading;

        [XmlElement(ElementName = "colHeading", IsNullable = false, Namespace = "")]
        public List<string> ColHeading {
            get => _colHeading;
            set {
                ColHeadingSpecified = true;
                _colHeading = value;
            }
        }

        [XmlIgnore]
        public bool ColHeadingSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.C.OCITableRow> _row;

        [XmlElement(ElementName = "row", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.C.OCITableRow> Row {
            get => _row;
            set {
                RowSpecified = true;
                _row = value;
            }
        }

        [XmlIgnore]
        public bool RowSpecified { get; set; }
        
    }
}
