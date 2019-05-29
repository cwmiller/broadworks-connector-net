using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostRoutingPoliciesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false)]
    public bool AllowEmergencyCalls { get; set; }
    [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false)]
    public bool AllowCallsToVoicePortal { get; set; }
 }
}
