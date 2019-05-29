using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "autoRebuildConfigEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DeviceManagementAutoRebuildConfigEntry> AutoRebuildConfigEntry { get; set; }
 }
}
