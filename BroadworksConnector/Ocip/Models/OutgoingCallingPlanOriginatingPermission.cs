using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum OutgoingCallingPlanOriginatingPermission{
    [XmlEnum(Name = "Disallow")]
    Disallow,
    [XmlEnum(Name = "Allow")]
    Allow,
    [XmlEnum(Name = "Authorization Code Required")]
    AuthorizationCodeRequired,
    [XmlEnum(Name = "Transfer To First Transfer Number")]
    TransferToFirstTransferNumber,
    [XmlEnum(Name = "Transfer To Second Transfer Number")]
    TransferToSecondTransferNumber,
    [XmlEnum(Name = "Transfer To Third Transfer Number")]
    TransferToThirdTransferNumber,
 }
}
