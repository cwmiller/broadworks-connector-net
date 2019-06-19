using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The type of the device management event.
    /// Automatic means that the event was triggered automatically by the
    /// system following a provisioning event from the user.
    /// Manual means that the user triggered the event directly.  The event
    /// was not a result of an indirect provisioning event.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventType
    {
        [XmlEnum(Name = "Automatic")]
        Automatic,
        [XmlEnum(Name = "Manual")]
        Manual,
    }
}
