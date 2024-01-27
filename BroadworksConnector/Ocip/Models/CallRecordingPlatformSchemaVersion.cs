using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Supported versions of the BroadWorks-specific extension metadata.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallRecordingPlatformSchemaVersion
    {
        [XmlEnum(Name = "1.0")]
        _10,
        [XmlEnum(Name = "2.0")]
        _20,
        [XmlEnum(Name = "3.0")]
        _30,
        [XmlEnum(Name = "4.0")]
        _40,
    }
}
