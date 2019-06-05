using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.DeviceManagementEventType _dmEventType;

    [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventType DmEventType {
        get => _dmEventType;
        set {
            DmEventTypeSpecified = true;
            _dmEventType = value;
        }
    }

    [XmlIgnore]
    public bool DmEventTypeSpecified { get; set; }
}
}
