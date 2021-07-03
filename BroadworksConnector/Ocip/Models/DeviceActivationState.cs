using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device activation state for Zero Touch Provisioning.
    /// 
    /// Deactivated: The device has not been onboarded yet and does not have an activation code. It cannot make or receive calls.
    /// Activating: An activation code was requested for the device, but it has not been consumed yet. The device is therefore not fully onboarded and
    /// cannot make or receive calls.
    /// Activated: The device has been onboarded. It can make and receive calls.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceActivationState
    {
        [XmlEnum(Name = "Deactivated")]
        Deactivated,
        [XmlEnum(Name = "Activating")]
        Activating,
        [XmlEnum(Name = "Activated")]
        Activated,
    }
}
