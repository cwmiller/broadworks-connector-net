using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemModifyRequestProtocolWebDAV 
{
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = true)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = true)]
    public string Password { get; set; }
    [XmlElement(ElementName = "fileServerFQDN", IsNullable = false)]
    public string FileServerFQDN { get; set; }
 }
}
