using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterQueueThresholdsGetRequest.
    /// <see cref="GroupCallCenterQueueThresholdsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5733""}]")]
    public class GroupCallCenterQueueThresholdsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected int _thresholdCurrentCallsInQueueYellow;

        [XmlElement(ElementName = "thresholdCurrentCallsInQueueYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(525)]
        public int ThresholdCurrentCallsInQueueYellow
        {
            get => _thresholdCurrentCallsInQueueYellow;
            set
            {
                ThresholdCurrentCallsInQueueYellowSpecified = true;
                _thresholdCurrentCallsInQueueYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallsInQueueYellowSpecified { get; set; }

        protected int _thresholdCurrentCallsInQueueRed;

        [XmlElement(ElementName = "thresholdCurrentCallsInQueueRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(525)]
        public int ThresholdCurrentCallsInQueueRed
        {
            get => _thresholdCurrentCallsInQueueRed;
            set
            {
                ThresholdCurrentCallsInQueueRedSpecified = true;
                _thresholdCurrentCallsInQueueRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallsInQueueRedSpecified { get; set; }

        protected int _thresholdCurrentLongestWaitingCallYellow;

        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentLongestWaitingCallYellow
        {
            get => _thresholdCurrentLongestWaitingCallYellow;
            set
            {
                ThresholdCurrentLongestWaitingCallYellowSpecified = true;
                _thresholdCurrentLongestWaitingCallYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentLongestWaitingCallYellowSpecified { get; set; }

        protected int _thresholdCurrentLongestWaitingCallRed;

        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentLongestWaitingCallRed
        {
            get => _thresholdCurrentLongestWaitingCallRed;
            set
            {
                ThresholdCurrentLongestWaitingCallRedSpecified = true;
                _thresholdCurrentLongestWaitingCallRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentLongestWaitingCallRedSpecified { get; set; }

        protected int _thresholdAverageEstimatedWaitTimeYellow;

        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageEstimatedWaitTimeYellow
        {
            get => _thresholdAverageEstimatedWaitTimeYellow;
            set
            {
                ThresholdAverageEstimatedWaitTimeYellowSpecified = true;
                _thresholdAverageEstimatedWaitTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageEstimatedWaitTimeYellowSpecified { get; set; }

        protected int _thresholdAverageEstimatedWaitTimeRed;

        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageEstimatedWaitTimeRed
        {
            get => _thresholdAverageEstimatedWaitTimeRed;
            set
            {
                ThresholdAverageEstimatedWaitTimeRedSpecified = true;
                _thresholdAverageEstimatedWaitTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageEstimatedWaitTimeRedSpecified { get; set; }

        protected int _thresholdAverageHandlingTimeYellow;

        [XmlElement(ElementName = "thresholdAverageHandlingTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageHandlingTimeYellow
        {
            get => _thresholdAverageHandlingTimeYellow;
            set
            {
                ThresholdAverageHandlingTimeYellowSpecified = true;
                _thresholdAverageHandlingTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageHandlingTimeYellowSpecified { get; set; }

        protected int _thresholdAverageHandlingTimeRed;

        [XmlElement(ElementName = "thresholdAverageHandlingTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageHandlingTimeRed
        {
            get => _thresholdAverageHandlingTimeRed;
            set
            {
                ThresholdAverageHandlingTimeRedSpecified = true;
                _thresholdAverageHandlingTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageHandlingTimeRedSpecified { get; set; }

        protected int _thresholdAverageSpeedOfAnswerYellow;

        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageSpeedOfAnswerYellow
        {
            get => _thresholdAverageSpeedOfAnswerYellow;
            set
            {
                ThresholdAverageSpeedOfAnswerYellowSpecified = true;
                _thresholdAverageSpeedOfAnswerYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageSpeedOfAnswerYellowSpecified { get; set; }

        protected int _thresholdAverageSpeedOfAnswerRed;

        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageSpeedOfAnswerRed
        {
            get => _thresholdAverageSpeedOfAnswerRed;
            set
            {
                ThresholdAverageSpeedOfAnswerRedSpecified = true;
                _thresholdAverageSpeedOfAnswerRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageSpeedOfAnswerRedSpecified { get; set; }

        protected bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        public bool EnableNotificationEmail
        {
            get => _enableNotificationEmail;
            set
            {
                EnableNotificationEmailSpecified = true;
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotificationEmailSpecified { get; set; }

        protected List<string> _notificationEmailAddress = new List<string>();

        [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5733")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> NotificationEmailAddress
        {
            get => _notificationEmailAddress;
            set
            {
                NotificationEmailAddressSpecified = true;
                _notificationEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NotificationEmailAddressSpecified { get; set; }

    }
}
