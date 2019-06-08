using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _roamingNetworkTable;

    [XmlElement(ElementName = "roamingNetworkTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RoamingNetworkTable {
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
