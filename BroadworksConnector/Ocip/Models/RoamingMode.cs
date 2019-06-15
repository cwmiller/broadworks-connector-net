using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The device configured roaming mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RoamingMode    {
            [XmlEnum(Name = "CDMA")]
        CDMA,
            [XmlEnum(Name = "GSM")]
        GSM,
            [XmlEnum(Name = "None")]
        None,
     }
}
