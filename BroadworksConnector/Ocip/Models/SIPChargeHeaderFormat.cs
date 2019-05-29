using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPChargeHeaderFormat{
    ChargeHeaderSip,
    ChargeHeaderTel,
    PChargeInfoSip,
    PChargeInfoTel,
    PAITelURI,
    DiversionSip,
 }
}
