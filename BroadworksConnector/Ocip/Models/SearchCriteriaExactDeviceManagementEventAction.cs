using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventAction : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

    [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction {
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
