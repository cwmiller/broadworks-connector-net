using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostRoutingPoliciesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false)]
    public bool AllowEmergencyCalls { get; set; }
    [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false)]
    public bool AllowCallsToVoicePortal { get; set; }
 }
}
