using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementAutoRebuildConfigEntry 
{
    [XmlElement(ElementName = "ociRequestPrefix", IsNullable = false)]
    public string OciRequestPrefix { get; set; }
    [XmlElement(ElementName = "autoRebuildEnabled", IsNullable = false)]
    public bool AutoRebuildEnabled { get; set; }
 }
}
