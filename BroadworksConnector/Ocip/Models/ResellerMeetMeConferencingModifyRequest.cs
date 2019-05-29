using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerMeetMeConferencingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "conferenceFromAddress", IsNullable = true)]
    public string ConferenceFromAddress { get; set; }
    [XmlElement(ElementName = "maxAllocatedPorts", IsNullable = false)]
    public int MaxAllocatedPorts { get; set; }
 }
}
