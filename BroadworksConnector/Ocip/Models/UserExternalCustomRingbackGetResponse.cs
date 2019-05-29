using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExternalCustomRingbackGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "sipRequestURI", IsNullable = false)]
    public string SipRequestURI { get; set; }
 }
}
