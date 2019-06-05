using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
    }
}
