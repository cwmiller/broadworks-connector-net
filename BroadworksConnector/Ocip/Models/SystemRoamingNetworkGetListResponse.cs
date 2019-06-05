using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _roamingNetworkTable;

    [XmlElement(ElementName = "roamingNetworkTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoamingNetworkTable {
        get => _roamingNetworkTable;
        set {
            RoamingNetworkTableSpecified = true;
            _roamingNetworkTable = value;
        }
    }

    [XmlIgnore]
    public bool RoamingNetworkTableSpecified { get; set; }
}
}
