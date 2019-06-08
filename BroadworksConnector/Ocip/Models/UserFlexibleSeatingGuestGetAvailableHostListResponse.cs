using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFlexibleSeatingGuestGetAvailableHostListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _hostUserTable;

    [XmlElement(ElementName = "hostUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable HostUserTable {
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
