using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> _autoRebuildConfigEntry;

    [XmlElement(ElementName = "autoRebuildConfigEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> AutoRebuildConfigEntry {
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
