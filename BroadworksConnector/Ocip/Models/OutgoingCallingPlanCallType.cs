using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum OutgoingCallingPlanCallType{
    CasualCalls,
    ChargeableDirectoryAssistance,
    International,
    Local,
    OperatorAssisted,
    PremiumServicesI,
    PremiumServicesII,
    SpecialServicesI,
    SpecialServicesII,
    Toll,
    TollFree,
 }
}
