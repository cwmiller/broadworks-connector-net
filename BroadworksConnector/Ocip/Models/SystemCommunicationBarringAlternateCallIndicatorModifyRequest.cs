using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringAlternateCallIndicatorModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false)]
    public string AlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "networkServerAlternateCallIndicator", IsNullable = false)]
    public string NetworkServerAlternateCallIndicator { get; set; }
 }
}
