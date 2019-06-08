using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemLicenseType{
    [XmlEnum(Name = "Lawful Intercept Event Monitoring")]
    LawfulInterceptEventMonitoring,
    [XmlEnum(Name = "Lawful Intercept Media Monitoring")]
    LawfulInterceptMediaMonitoring,
    [XmlEnum(Name = "Enterprise Voice Portal")]
    EnterpriseVoicePortal,
    [XmlEnum(Name = "Service Packs")]
    ServicePacks,
    [XmlEnum(Name = "SIP TCP")]
    SIPTCP,
    [XmlEnum(Name = "Realtime Accounting")]
    RealtimeAccounting,
    [XmlEnum(Name = "Network-Wide Messaging")]
    NetworkWideMessaging,
    [XmlEnum(Name = "Sh Interface")]
    ShInterface,
    [XmlEnum(Name = "Destination Trunk Group")]
    DestinationTrunkGroup,
    [XmlEnum(Name = "Deployment Studio")]
    DeploymentStudio,
    [XmlEnum(Name = "Session Admission Control")]
    SessionAdmissionControl,
    [XmlEnum(Name = "Session Data Replication")]
    SessionDataReplication,
    [XmlEnum(Name = "BroadWorks Mobile Manager")]
    BroadWorksMobileManager,
    [XmlEnum(Name = "System Voice Portal")]
    SystemVoicePortal,
    [XmlEnum(Name = "Number Portability Query")]
    NumberPortabilityQuery,
 }
}
