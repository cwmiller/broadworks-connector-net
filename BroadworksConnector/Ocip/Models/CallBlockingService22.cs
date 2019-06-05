using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallBlockingService22
    {
        [XmlEnum(Name = "OCP")]
        OCP,
        [XmlEnum(Name = "EOCP")]
        EOCP,
        [XmlEnum(Name = "ICP")]
        ICP,
        [XmlEnum(Name = "ACR")]
        ACR,
        [XmlEnum(Name = "SCR")]
        SCR,
        [XmlEnum(Name = "SCA")]
        SCA,
        [XmlEnum(Name = "AAC")]
        AAC,
        [XmlEnum(Name = "Intercept")]
        Intercept,
        [XmlEnum(Name = "PTT")]
        PTT,
        [XmlEnum(Name = "Communication Barring")]
        CommunicationBarring,
        [XmlEnum(Name = "SAC")]
        SAC,
        [XmlEnum(Name = "Incoming Communication Barring")]
        IncomingCommunicationBarring,
        [XmlEnum(Name = "Hierarchical Communication Barring")]
        HierarchicalCommunicationBarring,
        [XmlEnum(Name = "Incoming Hierarchical Communication Barring")]
        IncomingHierarchicalCommunicationBarring,
        [XmlEnum(Name = "BroadWorks Mobility Deny Originations")]
        BroadWorksMobilityDenyOriginations,
        [XmlEnum(Name = "BroadWorks Mobility Deny Terminations")]
        BroadWorksMobilityDenyTerminations,
        [XmlEnum(Name = "Enterprise Trunk Route Exhaust")]
        EnterpriseTrunkRouteExhaust,
        [XmlEnum(Name = "Call Park")]
        CallPark,
        [XmlEnum(Name = "Number Portability")]
        NumberPortability,
        [XmlEnum(Name = "Maximum Concurrent Terminating Alerting Requests")]
        MaximumConcurrentTerminatingAlertingRequests,
    }
}
