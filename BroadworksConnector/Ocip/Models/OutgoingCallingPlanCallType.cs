using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum OutgoingCallingPlanCallType{
    [XmlEnum(Name = "Casual Calls")]
    CasualCalls,
    [XmlEnum(Name = "Chargeable Directory Assistance")]
    ChargeableDirectoryAssistance,
    [XmlEnum(Name = "International")]
    International,
    [XmlEnum(Name = "Local")]
    Local,
    [XmlEnum(Name = "Operator Assisted")]
    OperatorAssisted,
    [XmlEnum(Name = "Premium Services I")]
    PremiumServicesI,
    [XmlEnum(Name = "Premium Services II")]
    PremiumServicesII,
    [XmlEnum(Name = "Special Services I")]
    SpecialServicesI,
    [XmlEnum(Name = "Special Services II")]
    SpecialServicesII,
    [XmlEnum(Name = "Toll")]
    Toll,
    [XmlEnum(Name = "Toll Free")]
    TollFree,
 }
}
