using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Location Network Device Option Type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LocationNetworkType    {
            [XmlEnum(Name = "Fixed")]
        Fixed,
            [XmlEnum(Name = "Mobile")]
        Mobile,
     }
}
