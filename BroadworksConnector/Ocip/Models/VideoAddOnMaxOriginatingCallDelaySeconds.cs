using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Maximum Originating Call Delay.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VideoAddOnMaxOriginatingCallDelaySeconds    {
            [XmlEnum(Name = "2")]
        _2,
            [XmlEnum(Name = "5")]
        _5,
            [XmlEnum(Name = "10")]
        _10,
     }
}
