using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// List of valid values to set to the resource priority header. q735.0 indicates the highest priority, q735.4 indicates the lowest priority.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ResourcePriorityValue    {
            [XmlEnum(Name = "q735.0")]
        Q7350,
            [XmlEnum(Name = "q735.1")]
        Q7351,
            [XmlEnum(Name = "q735.2")]
        Q7352,
            [XmlEnum(Name = "q735.3")]
        Q7353,
            [XmlEnum(Name = "q735.4")]
        Q7354,
     }
}
