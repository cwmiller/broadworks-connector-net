using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentThresholdProfileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "profileName", IsNullable = false)]
    public string ProfileName { get; set; }
    [XmlElement(ElementName = "newProfileName", IsNullable = false)]
    public string NewProfileName { get; set; }
    [XmlElement(ElementName = "profileDescription", IsNullable = true)]
    public string ProfileDescription { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = true)]
    public int? ThresholdCurrentCallStateIdleTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = true)]
    public int? ThresholdCurrentCallStateIdleTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = true)]
    public int? ThresholdCurrentCallStateOnCallTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = true)]
    public int? ThresholdCurrentCallStateOnCallTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = true)]
    public int? ThresholdCurrentAgentStateUnavailableTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = true)]
    public int? ThresholdCurrentAgentStateUnavailableTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = true)]
    public int? ThresholdAverageBusyInTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = true)]
    public int? ThresholdAverageBusyInTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = true)]
    public int? ThresholdAverageBusyOutTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = true)]
    public int? ThresholdAverageBusyOutTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = true)]
    public int? ThresholdAverageWrapUpTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = true)]
    public int? ThresholdAverageWrapUpTimeRed { get; set; }
    [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false)]
    public bool EnableNotificationEmail { get; set; }
    [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList NotificationEmailAddressList { get; set; }
    [XmlElement(ElementName = "agentUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList { get; set; }
 }
}
