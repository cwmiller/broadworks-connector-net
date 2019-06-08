using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

    [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel {
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
