using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMailParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = true)]
    public string PrimaryServerNetAddress { get; set; }
    [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = true)]
    public string SecondaryServerNetAddress { get; set; }
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "defaultSubject", IsNullable = true)]
    public string DefaultSubject { get; set; }
    [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false)]
    public bool SupportDNSSRVForMailServerAccess { get; set; }
    [XmlElement(ElementName = "secureMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SMTPSecureMode SecureMode { get; set; }
    [XmlElement(ElementName = "port", IsNullable = true)]
    public int? Port { get; set; }
 }
}
