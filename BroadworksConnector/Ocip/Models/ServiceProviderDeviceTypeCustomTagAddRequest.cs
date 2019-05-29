using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeCustomTagAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "tagName", IsNullable = false)]
    public string TagName { get; set; }
    [XmlElement(ElementName = "isTagValueEncrypted", IsNullable = false)]
    public bool IsTagValueEncrypted { get; set; }
    [XmlElement(ElementName = "tagValue", IsNullable = false)]
    public string TagValue { get; set; }
    [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = false)]
    public string TagValueToEncrypt { get; set; }
 }
}
