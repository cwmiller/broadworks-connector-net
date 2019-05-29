using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum OutgoingPinholeDigitPlanOriginatingPermission{
    Ignore,
    Allow,
    AuthorizationCodeRequired,
    TransferToFirstTransferNumber,
    TransferToSecondTransferNumber,
    TransferToThirdTransferNumber,
 }
}
