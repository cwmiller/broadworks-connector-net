using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

    [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel {
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
