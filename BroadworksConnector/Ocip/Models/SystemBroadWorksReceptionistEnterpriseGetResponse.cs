using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksReceptionistEnterpriseGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
