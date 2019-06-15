using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the External Custom Ringback feature to decide which type of settings to use.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExternalCustomRingbackSettingLevel    {
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "User")]
        User,
     }
}
