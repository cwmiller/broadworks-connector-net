using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _routingPeerTable;

    [XmlElement(ElementName = "routingPeerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingPeerTable {
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
