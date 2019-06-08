using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventStatusCompleted : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusCompleted _dmEventStatusCompleted;

    [XmlElement(ElementName = "dmEventStatusCompleted", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusCompleted DmEventStatusCompleted {
        get => _dmEventStatusCompleted;
        set {
            DmEventStatusCompletedSpecified = true;
            _dmEventStatusCompleted = value;
        }
    }

    [XmlIgnore]
    public bool DmEventStatusCompletedSpecified { get; set; }
}
}
