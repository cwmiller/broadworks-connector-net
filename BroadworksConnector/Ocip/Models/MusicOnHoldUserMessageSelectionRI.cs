using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Music On Hold User Message Selection.
    /// The following values are only used in AS data mode and will fail in XS data mode:
    /// URL
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MusicOnHoldUserMessageSelectionRI
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Custom")]
        Custom,
        [XmlEnum(Name = "URL")]
        URL,
    }
}
