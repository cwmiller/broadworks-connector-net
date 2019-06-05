using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventStatusCompleted : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.DeviceManagementEventStatusCompleted _dmEventStatusCompleted;

    [XmlElement(ElementName = "dmEventStatusCompleted", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventStatusCompleted DmEventStatusCompleted {
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
