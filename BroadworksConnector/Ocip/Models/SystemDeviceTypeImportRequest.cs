using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeImportRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "file", IsNullable = false)]
    public string File { get; set; }
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
 }
}
