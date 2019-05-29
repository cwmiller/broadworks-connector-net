using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMailParametersGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "primaryServerNetAddress", IsNullable = false)]
    public string PrimaryServerNetAddress { get; set; }
    [XmlElement(ElementName = "secondaryServerNetAddress", IsNullable = false)]
    public string SecondaryServerNetAddress { get; set; }
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "defaultSubject", IsNullable = false)]
    public string DefaultSubject { get; set; }
    [XmlElement(ElementName = "supportDNSSRVForMailServerAccess", IsNullable = false)]
    public bool SupportDNSSRVForMailServerAccess { get; set; }
    [XmlElement(ElementName = "secureMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SMTPSecureMode SecureMode { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
 }
}
