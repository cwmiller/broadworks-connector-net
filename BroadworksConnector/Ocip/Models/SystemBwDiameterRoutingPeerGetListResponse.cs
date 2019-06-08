using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _routingPeerTable;

    [XmlElement(ElementName = "routingPeerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RoutingPeerTable {
        get => _routingPeerTable;
        set {
            RoutingPeerTableSpecified = true;
            _routingPeerTable = value;
        }
    }

    [XmlIgnore]
    public bool RoutingPeerTableSpecified { get; set; }
}
}
