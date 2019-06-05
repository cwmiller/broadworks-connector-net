using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClientIdentityGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _clientIdentityTable;

    [XmlElement(ElementName = "clientIdentityTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ClientIdentityTable {
        get => _clientIdentityTable;
        set {
            ClientIdentityTableSpecified = true;
            _clientIdentityTable = value;
        }
    }

    [XmlIgnore]
    public bool ClientIdentityTableSpecified { get; set; }
}
}
