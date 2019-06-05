using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> _autoRebuildConfigEntry;

    [XmlElement(ElementName = "autoRebuildConfigEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> AutoRebuildConfigEntry {
        get => _autoRebuildConfigEntry;
        set {
            AutoRebuildConfigEntrySpecified = true;
            _autoRebuildConfigEntry = value;
        }
    }

    [XmlIgnore]
    public bool AutoRebuildConfigEntrySpecified { get; set; }
}
}
