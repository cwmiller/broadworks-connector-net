using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the Group Night Forwarding Service Activation for a user.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupNightForwardingUserServiceActivationMode
    {
        [XmlEnum(Name = "Use Group")]
        UseGroup,
        [XmlEnum(Name = "On")]
        On,
        [XmlEnum(Name = "Off")]
        Off,
    }
}
