using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkClassOfServiceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

    [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable {
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
