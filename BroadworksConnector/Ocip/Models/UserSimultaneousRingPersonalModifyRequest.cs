using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingPersonalModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SimultaneousRingSelection IncomingCalls { get; set; }
    [XmlElement(ElementName = "simRingPhoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList SimRingPhoneNumberList { get; set; }
 }
}
