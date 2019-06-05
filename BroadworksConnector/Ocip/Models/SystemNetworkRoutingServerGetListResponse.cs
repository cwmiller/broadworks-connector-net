using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkRoutingServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _networkRoutingServerTable;

    [XmlElement(ElementName = "networkRoutingServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable NetworkRoutingServerTable {
        get => _networkRoutingServerTable;
        set {
            NetworkRoutingServerTableSpecified = true;
            _networkRoutingServerTable = value;
        }
    }

    [XmlIgnore]
    public bool NetworkRoutingServerTableSpecified { get; set; }
}
}
