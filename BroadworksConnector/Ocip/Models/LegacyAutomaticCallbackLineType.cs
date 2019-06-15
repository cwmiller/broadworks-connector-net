using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Legacy Automatic Callback line type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LegacyAutomaticCallbackLineType    {
            [XmlEnum(Name = "Individual")]
        Individual,
            [XmlEnum(Name = "Coin")]
        Coin,
            [XmlEnum(Name = "Series")]
        Series,
            [XmlEnum(Name = "Hunt")]
        Hunt,
            [XmlEnum(Name = "Unassigned")]
        Unassigned,
            [XmlEnum(Name = "PBX")]
        PBX,
            [XmlEnum(Name = "Multiparty")]
        Multiparty,
            [XmlEnum(Name = "Choke")]
        Choke,
            [XmlEnum(Name = "Oos")]
        Oos,
            [XmlEnum(Name = "Nonspecific")]
        Nonspecific,
            [XmlEnum(Name = "Telecampus")]
        Telecampus,
            [XmlEnum(Name = "ISDN")]
        ISDN,
            [XmlEnum(Name = "Telekibutz")]
        Telekibutz,
            [XmlEnum(Name = "Spare")]
        Spare,
     }
}
