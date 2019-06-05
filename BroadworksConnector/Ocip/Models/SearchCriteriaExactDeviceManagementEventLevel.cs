using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

    [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel {
        get => _dmEventLevel;
        set {
            DmEventLevelSpecified = true;
            _dmEventLevel = value;
        }
    }

    [XmlIgnore]
    public bool DmEventLevelSpecified { get; set; }
}
}
