using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the Group Night Forwarding Service Activation for a group.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupNightForwardingGroupServiceActivationMode
    {
        [XmlEnum(Name = "Auto On")]
        AutoOn,
        [XmlEnum(Name = "On")]
        On,
        [XmlEnum(Name = "Off")]
        Off,
    }
}
