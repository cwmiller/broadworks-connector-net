using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallBlockingService22{
    OCP,
    EOCP,
    ICP,
    ACR,
    SCR,
    SCA,
    AAC,
    Intercept,
    PTT,
    CommunicationBarring,
    SAC,
    IncomingCommunicationBarring,
    HierarchicalCommunicationBarring,
    IncomingHierarchicalCommunicationBarring,
    BroadWorksMobilityDenyOriginations,
    BroadWorksMobilityDenyTerminations,
    EnterpriseTrunkRouteExhaust,
    CallPark,
    NumberPortability,
    MaximumConcurrentTerminatingAlertingRequests,
 }
}
