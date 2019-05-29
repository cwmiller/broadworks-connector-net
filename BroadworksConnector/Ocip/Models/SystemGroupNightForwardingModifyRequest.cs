using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGroupNightForwardingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "nightForwardGroupCallsWithinEnterprise", IsNullable = false)]
    public bool NightForwardGroupCallsWithinEnterprise { get; set; }
 }
}
