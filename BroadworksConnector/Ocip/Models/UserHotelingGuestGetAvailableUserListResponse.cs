using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingGuestGetAvailableUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _hostUserTable;

    [XmlElement(ElementName = "hostUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable HostUserTable {
        get => _hostUserTable;
        set {
            HostUserTableSpecified = true;
            _hostUserTable = value;
        }
    }

    [XmlIgnore]
    public bool HostUserTableSpecified { get; set; }
}
}
