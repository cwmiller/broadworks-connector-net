using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemOfficeZoneGetZoneUsageListRequest.
    /// The response contains a table of all Office Zones that
    /// contain the specific Zone. The column headings
    /// are "Name" and "Description"
        /// <see cref="SystemOfficeZoneGetZoneUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOfficeZoneGetZoneUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _officeZoneTable;

        [XmlElement(ElementName = "officeZoneTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OfficeZoneTable {
            get => _officeZoneTable;
            set {
                OfficeZoneTableSpecified = true;
                _officeZoneTable = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneTableSpecified { get; set; }
        
    }
}
