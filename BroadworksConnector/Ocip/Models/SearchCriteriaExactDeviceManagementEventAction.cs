using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventAction : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

    [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction {
        get => _dmEventAction;
        set {
            DmEventActionSpecified = true;
            _dmEventAction = value;
        }
    }

    [XmlIgnore]
    public bool DmEventActionSpecified { get; set; }
}
}
