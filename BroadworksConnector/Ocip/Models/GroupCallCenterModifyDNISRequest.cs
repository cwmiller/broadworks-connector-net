using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyDNISRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "dnisKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey { get; set; }
    [XmlElement(ElementName = "newDNISName", IsNullable = false)]
    public string NewDNISName { get; set; }
    [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = true)]
    public string DnisPhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = true)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "useCustomCLIDSettings", IsNullable = false)]
    public bool UseCustomCLIDSettings { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = true)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = true)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "useCustomDnisAnnouncementSettings", IsNullable = false)]
    public bool UseCustomDnisAnnouncementSettings { get; set; }
    [XmlElement(ElementName = "priority", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISPriority Priority { get; set; }
    [XmlElement(ElementName = "allowOutgoingACDCall", IsNullable = false)]
    public bool AllowOutgoingACDCall { get; set; }
 }
}
