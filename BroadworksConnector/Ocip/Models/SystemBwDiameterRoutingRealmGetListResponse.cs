using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingRealmGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _routingRealmTable;

    [XmlElement(ElementName = "routingRealmTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingRealmTable {
        get => _routingRealmTable;
        set {
            RoutingRealmTableSpecified = true;
            _routingRealmTable = value;
        }
    }

    [XmlIgnore]
    public bool RoutingRealmTableSpecified { get; set; }
}
}
