using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksReceptionistEnterpriseModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _maxMonitoredUsers;

    [XmlElement(ElementName = "maxMonitoredUsers", IsNullable = false, Namespace = "")]
    public int MaxMonitoredUsers {
        get => _maxMonitoredUsers;
        set {
            MaxMonitoredUsersSpecified = true;
            _maxMonitoredUsers = value;
        }
    }

    [XmlIgnore]
    public bool MaxMonitoredUsersSpecified { get; set; }
}
}
