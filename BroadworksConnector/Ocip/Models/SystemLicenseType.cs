using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SystemLicenseType{
    LawfulInterceptEventMonitoring,
    LawfulInterceptMediaMonitoring,
    EnterpriseVoicePortal,
    ServicePacks,
    SIPTCP,
    RealtimeAccounting,
    NetworkWideMessaging,
    ShInterface,
    DestinationTrunkGroup,
    DeploymentStudio,
    SessionAdmissionControl,
    SessionDataReplication,
    BroadWorksMobileManager,
    SystemVoicePortal,
    NumberPortabilityQuery,
 }
}
