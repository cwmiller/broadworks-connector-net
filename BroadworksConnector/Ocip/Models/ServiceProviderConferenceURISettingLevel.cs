using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the service provider conference URI
    /// setting to decide which level of settings to use.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderConferenceURISettingLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
    }
}
