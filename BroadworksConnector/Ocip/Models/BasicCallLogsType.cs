using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Log type.
    /// Replaced By: CallLogsType
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BasicCallLogsType    {
            [XmlEnum(Name = "Placed")]
        Placed,
            [XmlEnum(Name = "Received")]
        Received,
            [XmlEnum(Name = "Missed")]
        Missed,
     }
}
