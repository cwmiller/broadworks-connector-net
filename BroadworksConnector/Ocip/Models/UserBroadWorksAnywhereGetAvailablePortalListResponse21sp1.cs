using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _portalTable;

    [XmlElement(ElementName = "portalTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PortalTable {
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
