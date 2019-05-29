using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueThresholdsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallsInQueueYellow", IsNullable = true)]
    public int? ThresholdCurrentCallsInQueueYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentCallsInQueueRed", IsNullable = true)]
    public int? ThresholdCurrentCallsInQueueRed { get; set; }
    [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallYellow", IsNullable = true)]
    public int? ThresholdCurrentLongestWaitingCallYellow { get; set; }
    [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallRed", IsNullable = true)]
    public int? ThresholdCurrentLongestWaitingCallRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeYellow", IsNullable = true)]
    public int? ThresholdAverageEstimatedWaitTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeRed", IsNullable = true)]
    public int? ThresholdAverageEstimatedWaitTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageHandlingTimeYellow", IsNullable = true)]
    public int? ThresholdAverageHandlingTimeYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageHandlingTimeRed", IsNullable = true)]
    public int? ThresholdAverageHandlingTimeRed { get; set; }
    [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerYellow", IsNullable = true)]
    public int? ThresholdAverageSpeedOfAnswerYellow { get; set; }
    [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerRed", IsNullable = true)]
    public int? ThresholdAverageSpeedOfAnswerRed { get; set; }
    [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false)]
    public bool EnableNotificationEmail { get; set; }
    [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CallCenterQueueThresholdReplacementNotificationEmailList NotificationEmailAddressList { get; set; }
 }
}
