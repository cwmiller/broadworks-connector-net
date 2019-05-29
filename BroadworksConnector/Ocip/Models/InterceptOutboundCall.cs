using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum InterceptOutboundCall{
    BlockAll,
    AllowOutboundLocalCalls,
    AllowOutboundEnterpriseAndGroupCalls,
 }
}
