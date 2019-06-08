using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallingPlanService{
    [XmlEnum(Name = "Incoming Calling Plan")]
    IncomingCallingPlan,
    [XmlEnum(Name = "Outgoing Calling Plan")]
    OutgoingCallingPlan,
 }
}
