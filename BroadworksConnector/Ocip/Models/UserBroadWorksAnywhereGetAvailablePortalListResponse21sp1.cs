using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1.
    /// Contains a table with column headings: "Portal ID", "Portal Name", "Phone Number", "Extension", "Language".
        /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _portalTable;

        [XmlElement(ElementName = "portalTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PortalTable {
            get => _portalTable;
            set {
                PortalTableSpecified = true;
                _portalTable = value;
            }
        }

        [XmlIgnore]
        public bool PortalTableSpecified { get; set; }
        
    }
}
