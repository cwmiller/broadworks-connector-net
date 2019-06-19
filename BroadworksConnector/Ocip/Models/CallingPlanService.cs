using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Calling Plan Service type
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingPlanService
    {
        [XmlEnum(Name = "Incoming Calling Plan")]
        IncomingCallingPlan,
        [XmlEnum(Name = "Outgoing Calling Plan")]
        OutgoingCallingPlan,
    }
}
