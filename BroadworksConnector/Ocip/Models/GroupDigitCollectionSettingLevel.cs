using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the group digit collection feature to decide which type of settings to use.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDigitCollectionSettingLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
