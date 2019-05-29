using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponseProtocolFile 
{
    [XmlElement(ElementName = "replicated", IsNullable = false)]
    public bool Replicated { get; set; }
 }
}
