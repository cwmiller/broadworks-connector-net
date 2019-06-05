using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetTranslationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _routingTable;

    [XmlElement(ElementName = "routingTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingTable {
        get => _routingTable;
        set {
            RoutingTableSpecified = true;
            _routingTable = value;
        }
    }

    [XmlIgnore]
    public bool RoutingTableSpecified { get; set; }
}
}
