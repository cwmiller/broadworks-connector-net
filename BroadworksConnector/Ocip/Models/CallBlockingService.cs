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
    /// The following types are only used in XS data mode:
    /// Incoming Communication Barring
    /// Hierarchical Communication Barring
    /// Incoming Hierarchical Communication Barring
    /// 
    /// Replaced by: CallBlockingService22
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallBlockingService
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
    }
}
