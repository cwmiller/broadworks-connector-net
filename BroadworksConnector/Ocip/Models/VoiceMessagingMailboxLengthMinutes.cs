using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Mailbox length for voice messages
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingMailboxLengthMinutes    {
            [XmlEnum(Name = "10")]
        _10,
            [XmlEnum(Name = "20")]
        _20,
            [XmlEnum(Name = "30")]
        _30,
            [XmlEnum(Name = "40")]
        _40,
            [XmlEnum(Name = "50")]
        _50,
            [XmlEnum(Name = "60")]
        _60,
            [XmlEnum(Name = "70")]
        _70,
            [XmlEnum(Name = "80")]
        _80,
            [XmlEnum(Name = "90")]
        _90,
            [XmlEnum(Name = "100")]
        _100,
            [XmlEnum(Name = "200")]
        _200,
            [XmlEnum(Name = "300")]
        _300,
            [XmlEnum(Name = "400")]
        _400,
            [XmlEnum(Name = "500")]
        _500,
            [XmlEnum(Name = "600")]
        _600,
            [XmlEnum(Name = "700")]
        _700,
            [XmlEnum(Name = "800")]
        _800,
            [XmlEnum(Name = "900")]
        _900,
     }
}
