using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCITableRow type is used in responses only, never in requests. It occurs
    /// inside the OCITable type. The OCITableRow consists columns of strings.
    /// Clients should not assume any particular column order as future
    /// revisions of the protocol may move or add columns. See the OCITable data type
    /// for more information.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
     
    public class OCITableRow 
    {

        
        private List<string> _col;

        [XmlElement(ElementName = "col", IsNullable = false, Namespace = "")]
        public List<string> Col {
            get => _col;
            set {
                ColSpecified = true;
                _col = value;
            }
        }

        [XmlIgnore]
        public bool ColSpecified { get; set; }
        
    }
}
