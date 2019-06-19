using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for extended file resource usage.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExtendedFileResourceSelection
    {
        [XmlEnum(Name = "File")]
        File,
        [XmlEnum(Name = "URL")]
        URL,
        [XmlEnum(Name = "Default")]
        Default,
    }
}
