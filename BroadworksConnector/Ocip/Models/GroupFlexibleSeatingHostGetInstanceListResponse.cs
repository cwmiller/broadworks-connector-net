using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFlexibleSeatingHostGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
        /// <see cref="GroupFlexibleSeatingHostGetInstanceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFlexibleSeatingHostGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _flexibleSeatingHostTable;

        [XmlElement(ElementName = "flexibleSeatingHostTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FlexibleSeatingHostTable {
            get => _flexibleSeatingHostTable;
            set {
                FlexibleSeatingHostTableSpecified = true;
                _flexibleSeatingHostTable = value;
            }
        }

        [XmlIgnore]
        public bool FlexibleSeatingHostTableSpecified { get; set; }
        
    }
}
