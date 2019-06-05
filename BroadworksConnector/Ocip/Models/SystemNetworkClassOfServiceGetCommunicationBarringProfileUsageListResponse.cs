using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkClassOfServiceGetCommunicationBarringProfileUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

    [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable {
        get => _networkClassOfServiceTable;
        set {
            NetworkClassOfServiceTableSpecified = true;
            _networkClassOfServiceTable = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceTableSpecified { get; set; }
}
}
