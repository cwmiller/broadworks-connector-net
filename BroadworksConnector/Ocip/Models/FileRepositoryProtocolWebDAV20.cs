using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FileRepositoryProtocolWebDAV20 
{
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "extendedFileCaptureSupport", IsNullable = false)]
    public bool ExtendedFileCaptureSupport { get; set; }
 }
}
