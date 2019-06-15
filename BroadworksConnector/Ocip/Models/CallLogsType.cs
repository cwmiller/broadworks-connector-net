using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Log type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallLogsType    {
            [XmlEnum(Name = "Placed")]
        Placed,
            [XmlEnum(Name = "Received")]
        Received,
            [XmlEnum(Name = "Missed")]
        Missed,
     }
}
