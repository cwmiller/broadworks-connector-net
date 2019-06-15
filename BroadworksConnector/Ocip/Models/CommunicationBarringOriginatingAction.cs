using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible originating actions for Communication Barring.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringOriginatingAction    {
            [XmlEnum(Name = "Allow")]
        Allow,
            [XmlEnum(Name = "Allow Timed")]
        AllowTimed,
            [XmlEnum(Name = "Block")]
        Block,
            [XmlEnum(Name = "Authorization Code")]
        AuthorizationCode,
            [XmlEnum(Name = "Authorization Code Timed")]
        AuthorizationCodeTimed,
            [XmlEnum(Name = "Treatment")]
        Treatment,
            [XmlEnum(Name = "Transfer")]
        Transfer,
     }
}
