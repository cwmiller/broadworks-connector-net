using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Route Point failover status.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RoutePointFailoverStatus    {
            [XmlEnum(Name = "Normal")]
        Normal,
            [XmlEnum(Name = "Failover")]
        Failover,
     }
}
