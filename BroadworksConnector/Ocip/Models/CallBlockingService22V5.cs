using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible types of Call Blocking Services.
    /// The following enumeration values are only used in AS Data mode:
    /// PTT
    /// SAC
    /// BroadWorks Mobility Deny Originations
    /// BroadWorks Mobility Deny Terminations
    /// Enterprise Trunk Route Exhaust
    /// Call Park
    /// Number Portability
    /// Maximum Concurrent Terminating Alerting Requests
    /// Enterprise Trunk Route Exhaust Busy
    /// The following types are only used in XS data mode:
    /// Incoming Communication Barring
    /// Hierarchical Communication Barring
    /// Incoming Hierarchical Communication Barring
    /// The following type is only used in XS data mode and ignored in AS data mode:
    /// Calling Name Retrieval
    /// Replaced by: CallBlockingService23V5
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallBlockingService22V5
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
        [XmlEnum(Name = "Automatic Collect Call")]
        AutomaticCollectCall,
        [XmlEnum(Name = "TCUG")]
        TCUG,
        [XmlEnum(Name = "Calling Name Retrieval")]
        CallingNameRetrieval,
        [XmlEnum(Name = "Enterprise Trunk Route Exhaust Busy")]
        EnterpriseTrunkRouteExhaustBusy,
    }
}
