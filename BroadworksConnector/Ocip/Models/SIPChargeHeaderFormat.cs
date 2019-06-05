using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPChargeHeaderFormat{
    [XmlEnum(Name = "ChargeHeaderSip")]
    ChargeHeaderSip,
    [XmlEnum(Name = "ChargeHeaderTel")]
    ChargeHeaderTel,
    [XmlEnum(Name = "PChargeInfoSip")]
    PChargeInfoSip,
    [XmlEnum(Name = "PChargeInfoTel")]
    PChargeInfoTel,
    [XmlEnum(Name = "PAITelURI")]
    PAITelURI,
    [XmlEnum(Name = "DiversionSip")]
    DiversionSip,
 }
}
