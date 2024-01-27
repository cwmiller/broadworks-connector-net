using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The default classification for calls under the Mcc/Mnc based location system for originating SIP INVITEs without PANI headers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DefaultMccMncBasedLocation
    {
        [XmlEnum(Name = "Local")]
        Local,
        [XmlEnum(Name = "Roaming")]
        Roaming,
    }
}
