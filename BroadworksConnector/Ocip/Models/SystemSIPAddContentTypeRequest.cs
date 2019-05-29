using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAddContentTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "contentType", IsNullable = false)]
    public string ContentType { get; set; }
    [XmlElement(ElementName = "interface", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemSIPSupportedInterface Interface { get; set; }
 }
}
