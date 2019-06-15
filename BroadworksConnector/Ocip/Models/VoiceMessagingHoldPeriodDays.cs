using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Hold period for voice messages
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingHoldPeriodDays    {
            [XmlEnum(Name = "0")]
        _0,
            [XmlEnum(Name = "1")]
        _1,
            [XmlEnum(Name = "2")]
        _2,
            [XmlEnum(Name = "3")]
        _3,
            [XmlEnum(Name = "4")]
        _4,
            [XmlEnum(Name = "5")]
        _5,
            [XmlEnum(Name = "6")]
        _6,
            [XmlEnum(Name = "7")]
        _7,
            [XmlEnum(Name = "15")]
        _15,
            [XmlEnum(Name = "30")]
        _30,
            [XmlEnum(Name = "60")]
        _60,
     }
}
