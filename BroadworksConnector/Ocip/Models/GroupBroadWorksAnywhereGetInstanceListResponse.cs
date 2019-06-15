using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksAnywhereGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
        /// <see cref="GroupBroadWorksAnywhereGetInstanceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupBroadWorksAnywhereGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _broadWorksAnywhereTable;

        [XmlElement(ElementName = "broadWorksAnywhereTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable BroadWorksAnywhereTable {
            get => _broadWorksAnywhereTable;
            set {
                BroadWorksAnywhereTableSpecified = true;
                _broadWorksAnywhereTable = value;
            }
        }

        [XmlIgnore]
        public bool BroadWorksAnywhereTableSpecified { get; set; }
        
    }
}
