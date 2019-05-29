using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVerifyTranslationAndRoutingRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "parameters", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters Parameters { get; set; }
    [XmlElement(ElementName = "sipMessage", IsNullable = false)]
    public string SipMessage { get; set; }
 }
}
