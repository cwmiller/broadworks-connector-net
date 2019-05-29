using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "dnisPhoneNumber", IsNullable = false)]
    public string DnisPhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "useCustomCLIDSettings", IsNullable = false)]
    public bool UseCustomCLIDSettings { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "useCustomDnisAnnouncementSettings", IsNullable = false)]
    public bool UseCustomDnisAnnouncementSettings { get; set; }
    [XmlElement(ElementName = "allowOutgoingACDCall", IsNullable = false)]
    public bool AllowOutgoingACDCall { get; set; }
 }
}
