using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

    [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel {
        get => _deviceLevel;
        set {
            DeviceLevelSpecified = true;
            _deviceLevel = value;
        }
    }

    [XmlIgnore]
    public bool DeviceLevelSpecified { get; set; }
}
}
