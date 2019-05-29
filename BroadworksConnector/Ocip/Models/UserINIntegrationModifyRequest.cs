using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserINIntegrationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "originatingServiceKey", IsNullable = true)]
    public int? OriginatingServiceKey { get; set; }
    [XmlElement(ElementName = "terminatingServiceKey", IsNullable = true)]
    public int? TerminatingServiceKey { get; set; }
 }
}
