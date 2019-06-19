using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the action of a Diameter Route.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DiameterRouteAction
    {
        [XmlEnum(Name = "Local")]
        Local,
        [XmlEnum(Name = "Relay")]
        Relay,
    }
}
