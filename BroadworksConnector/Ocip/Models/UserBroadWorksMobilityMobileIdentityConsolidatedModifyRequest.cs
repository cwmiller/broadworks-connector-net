using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityMobileIdentityConsolidatedModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "mobileNumber", IsNullable = false)]
    public string MobileNumber { get; set; }
    [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false)]
    public bool DeleteExistingDevices { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
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
    [XmlElement(ElementName = "devicesToRing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing DevicesToRing { get; set; }
    [XmlElement(ElementName = "includeSharedCallAppearance", IsNullable = false)]
    public bool IncludeSharedCallAppearance { get; set; }
    [XmlElement(ElementName = "includeBroadworksAnywhere", IsNullable = false)]
    public bool IncludeBroadworksAnywhere { get; set; }
    [XmlElement(ElementName = "includeExecutiveAssistant", IsNullable = false)]
    public bool IncludeExecutiveAssistant { get; set; }
    [XmlElement(ElementName = "mobileNumbersAlerted", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList MobileNumbersAlerted { get; set; }
    [XmlElement(ElementName = "enableCallAnchoring", IsNullable = false)]
    public bool EnableCallAnchoring { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ScheduleGlobalKey TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ScheduleGlobalKey HolidaySchedule { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = true)]
    public string OutboundAlternateNumber { get; set; }
    [XmlElement(ElementName = "enableDirectRouting", IsNullable = false)]
    public bool EnableDirectRouting { get; set; }
    [XmlElement(ElementName = "markCDRAsEnterpriseGroupCalls", IsNullable = false)]
    public bool MarkCDRAsEnterpriseGroupCalls { get; set; }
    [XmlElement(ElementName = "useMobilityConnectedIdentity", IsNullable = false)]
    public bool UseMobilityConnectedIdentity { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true)]
    public string NetworkTranslationIndex { get; set; }
 }
}
