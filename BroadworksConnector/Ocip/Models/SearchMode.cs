using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Search mode when searching for string data.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SearchMode    {
            [XmlEnum(Name = "Starts With")]
        StartsWith,
            [XmlEnum(Name = "Contains")]
        Contains,
            [XmlEnum(Name = "Equal To")]
        EqualTo,
     }
}
