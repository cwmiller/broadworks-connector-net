using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// System User Calling Line Id Options.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemUserCallingLineIdSelection    {
            [XmlEnum(Name = "Disable All")]
        DisableAll,
            [XmlEnum(Name = "Enable All")]
        EnableAll,
            [XmlEnum(Name = "Enable All Except Emergency")]
        EnableAllExceptEmergency,
            [XmlEnum(Name = "Enable Emergency Only")]
        EnableEmergencyOnly,
     }
}
