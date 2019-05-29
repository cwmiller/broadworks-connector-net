using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExternalCustomRingbackModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "sipRequestURI", IsNullable = true)]
    public string SipRequestURI { get; set; }
 }
}
