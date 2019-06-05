using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderOfficeZoneGetAssignedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _officeZoneTable;

    [XmlElement(ElementName = "officeZoneTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable OfficeZoneTable {
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
