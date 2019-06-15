using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneCallingRestrictionsZoneGetListRequest.
    /// Contains a table of all the zones in the system. The column headings are "Zone Name" , "Physical
    /// Location".
    /// Replaced by: SystemZoneGetListResponse
        /// <see cref="SystemZoneCallingRestrictionsZoneGetListRequest"/>
        /// <see cref="SystemZoneGetListResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingRestrictionsZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _zoneTable;

        [XmlElement(ElementName = "zoneTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ZoneTable {
            get => _zoneTable;
            set {
                ZoneTableSpecified = true;
                _zoneTable = value;
            }
        }

        [XmlIgnore]
        public bool ZoneTableSpecified { get; set; }
        
    }
}
