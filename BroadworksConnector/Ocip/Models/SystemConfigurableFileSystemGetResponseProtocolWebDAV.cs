using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponseProtocolWebDAV 
{
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "fileServerFQDN", IsNullable = false)]
    public string FileServerFQDN { get; set; }
 }
}
