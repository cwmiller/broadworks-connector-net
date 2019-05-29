using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueThresholdsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallsInQueueYellow", IsNullable = false)]
    public int ThresholdCurrentCallsInQueueYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallsInQueueRed", IsNullable = false)]
    public int ThresholdCurrentCallsInQueueRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallYellow", IsNullable = false)]
    public int ThresholdCurrentLongestWaitingCallYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallRed", IsNullable = false)]
    public int ThresholdCurrentLongestWaitingCallRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeYellow", IsNullable = false)]
    public int ThresholdAverageEstimatedWaitTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeRed", IsNullable = false)]
    public int ThresholdAverageEstimatedWaitTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageHandlingTimeYellow", IsNullable = false)]
    public int ThresholdAverageHandlingTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageHandlingTimeRed", IsNullable = false)]
    public int ThresholdAverageHandlingTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerYellow", IsNullable = false)]
    public int ThresholdAverageSpeedOfAnswerYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerRed", IsNullable = false)]
    public int ThresholdAverageSpeedOfAnswerRed { get; set; }
    [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false)]
    public bool EnableNotificationEmail { get; set; }
    [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false)]
    public List<string> NotificationEmailAddress { get; set; }
 }
}
