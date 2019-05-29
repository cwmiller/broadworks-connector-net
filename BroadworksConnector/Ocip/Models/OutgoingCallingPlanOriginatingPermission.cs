using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum OutgoingCallingPlanOriginatingPermission{
    Disallow,
    Allow,
    AuthorizationCodeRequired,
    TransferToFirstTransferNumber,
    TransferToSecondTransferNumber,
    TransferToThirdTransferNumber,
 }
}
