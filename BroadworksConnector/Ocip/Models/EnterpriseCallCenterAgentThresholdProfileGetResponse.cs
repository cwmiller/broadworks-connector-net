using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterAgentThresholdProfileGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "profileDescription", IsNullable = false)]
    public string ProfileDescription { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = false)]
    public int ThresholdCurrentCallStateIdleTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = false)]
    public int ThresholdCurrentCallStateIdleTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = false)]
    public int ThresholdCurrentCallStateOnCallTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = false)]
    public int ThresholdCurrentCallStateOnCallTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = false)]
    public int ThresholdCurrentAgentStateUnavailableTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = false)]
    public int ThresholdCurrentAgentStateUnavailableTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = false)]
    public int ThresholdAverageBusyInTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = false)]
    public int ThresholdAverageBusyInTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = false)]
    public int ThresholdAverageBusyOutTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = false)]
    public int ThresholdAverageBusyOutTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = false)]
    public int ThresholdAverageWrapUpTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = false)]
    public int ThresholdAverageWrapUpTimeRed { get; set; }
    [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false)]
    public bool EnableNotificationEmail { get; set; }
    [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false)]
    public List<string> NotificationEmailAddress { get; set; }
    [XmlElement(ElementName = "agentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentTable { get; set; }
 }
}
