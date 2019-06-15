using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderOfficeZoneGetAssignedListRequest.
    /// Contains a table of all Office Zones assigned to the
    /// service provider. The column headings are: "Name", "Description" and "Default".
        /// <see cref="ServiceProviderOfficeZoneGetAssignedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderOfficeZoneGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
