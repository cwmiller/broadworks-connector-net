using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityMobileIdentityGetResponse22V2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "isPrimary", IsNullable = false)]
    public bool IsPrimary { get; set; }
    [XmlElement(ElementName = "enableAlerting", IsNullable = false)]
    public bool EnableAlerting { get; set; }
    [XmlElement(ElementName = "alertAgentCalls", IsNullable = false)]
    public bool AlertAgentCalls { get; set; }
    [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false)]
    public bool AlertClickToDialCalls { get; set; }
    [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false)]
    public bool AlertGroupPagingCalls { get; set; }
    [XmlElement(ElementName = "useMobilityCallingLineID", IsNullable = false)]
    public bool UseMobilityCallingLineID { get; set; }
    [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false)]
    public bool EnableDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false)]
    public bool RequireAnswerConfirmation { get; set; }
    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false)]
    public bool BroadworksCallControl { get; set; }
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false)]
    public bool DenyCallOriginations { get; set; }
    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false)]
    public bool DenyCallTerminations { get; set; }
    [XmlElement(ElementName = "effectiveEnableLocationServices", IsNullable = false)]
    public bool EffectiveEnableLocationServices { get; set; }
    [XmlElement(ElementName = "effectiveEnableMSRNLookup", IsNullable = false)]
    public bool EffectiveEnableMSRNLookup { get; set; }
    [XmlElement(ElementName = "effectiveEnableMobileStateChecking", IsNullable = false)]
    public bool EffectiveEnableMobileStateChecking { get; set; }
    [XmlElement(ElementName = "effectiveEnableAnnouncementSuppression", IsNullable = false)]
    public bool EffectiveEnableAnnouncementSuppression { get; set; }
    [XmlElement(ElementName = "effectiveDenyCallOriginations", IsNullable = false)]
    public bool EffectiveDenyCallOriginations { get; set; }
    [XmlElement(ElementName = "effectiveDenyCallTerminations", IsNullable = false)]
    public bool EffectiveDenyCallTerminations { get; set; }
    [XmlElement(ElementName = "devicesToRing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing DevicesToRing { get; set; }
    [XmlElement(ElementName = "includeSharedCallAppearance", IsNullable = false)]
    public bool IncludeSharedCallAppearance { get; set; }
    [XmlElement(ElementName = "includeBroadworksAnywhere", IsNullable = false)]
    public bool IncludeBroadworksAnywhere { get; set; }
    [XmlElement(ElementName = "includeExecutiveAssistant", IsNullable = false)]
    public bool IncludeExecutiveAssistant { get; set; }
    [XmlElement(ElementName = "enableCallAnchoring", IsNullable = false)]
    public bool EnableCallAnchoring { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleGlobalKey TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleGlobalKey HolidaySchedule { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false)]
    public string OutboundAlternateNumber { get; set; }
    [XmlElement(ElementName = "enableDirectRouting", IsNullable = false)]
    public bool EnableDirectRouting { get; set; }
    [XmlElement(ElementName = "markCDRAsEnterpriseGroupCalls", IsNullable = false)]
    public bool MarkCDRAsEnterpriseGroupCalls { get; set; }
    [XmlElement(ElementName = "useMobilityConnectedIdentity", IsNullable = false)]
    public bool UseMobilityConnectedIdentity { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false)]
    public string NetworkTranslationIndex { get; set; }
    [XmlElement(ElementName = "mobileNumberAlertedTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileNumberAlertedTable { get; set; }
 }
}
