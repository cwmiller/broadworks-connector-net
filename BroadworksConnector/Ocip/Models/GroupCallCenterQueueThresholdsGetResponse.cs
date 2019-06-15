using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterQueueThresholdsGetRequest.
        /// <see cref="GroupCallCenterQueueThresholdsGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterQueueThresholdsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private int _thresholdCurrentCallsInQueueYellow;

        [XmlElement(ElementName = "thresholdCurrentCallsInQueueYellow", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallsInQueueYellow {
            get => _thresholdCurrentCallsInQueueYellow;
            set {
                ThresholdCurrentCallsInQueueYellowSpecified = true;
                _thresholdCurrentCallsInQueueYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallsInQueueYellowSpecified { get; set; }
        
        private int _thresholdCurrentCallsInQueueRed;

        [XmlElement(ElementName = "thresholdCurrentCallsInQueueRed", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallsInQueueRed {
            get => _thresholdCurrentCallsInQueueRed;
            set {
                ThresholdCurrentCallsInQueueRedSpecified = true;
                _thresholdCurrentCallsInQueueRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallsInQueueRedSpecified { get; set; }
        
        private int _thresholdCurrentLongestWaitingCallYellow;

        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallYellow", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentLongestWaitingCallYellow {
            get => _thresholdCurrentLongestWaitingCallYellow;
            set {
                ThresholdCurrentLongestWaitingCallYellowSpecified = true;
                _thresholdCurrentLongestWaitingCallYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentLongestWaitingCallYellowSpecified { get; set; }
        
        private int _thresholdCurrentLongestWaitingCallRed;

        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallRed", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentLongestWaitingCallRed {
            get => _thresholdCurrentLongestWaitingCallRed;
            set {
                ThresholdCurrentLongestWaitingCallRedSpecified = true;
                _thresholdCurrentLongestWaitingCallRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentLongestWaitingCallRedSpecified { get; set; }
        
        private int _thresholdAverageEstimatedWaitTimeYellow;

        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageEstimatedWaitTimeYellow {
            get => _thresholdAverageEstimatedWaitTimeYellow;
            set {
                ThresholdAverageEstimatedWaitTimeYellowSpecified = true;
                _thresholdAverageEstimatedWaitTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageEstimatedWaitTimeYellowSpecified { get; set; }
        
        private int _thresholdAverageEstimatedWaitTimeRed;

        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageEstimatedWaitTimeRed {
            get => _thresholdAverageEstimatedWaitTimeRed;
            set {
                ThresholdAverageEstimatedWaitTimeRedSpecified = true;
                _thresholdAverageEstimatedWaitTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageEstimatedWaitTimeRedSpecified { get; set; }
        
        private int _thresholdAverageHandlingTimeYellow;

        [XmlElement(ElementName = "thresholdAverageHandlingTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageHandlingTimeYellow {
            get => _thresholdAverageHandlingTimeYellow;
            set {
                ThresholdAverageHandlingTimeYellowSpecified = true;
                _thresholdAverageHandlingTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageHandlingTimeYellowSpecified { get; set; }
        
        private int _thresholdAverageHandlingTimeRed;

        [XmlElement(ElementName = "thresholdAverageHandlingTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageHandlingTimeRed {
            get => _thresholdAverageHandlingTimeRed;
            set {
                ThresholdAverageHandlingTimeRedSpecified = true;
                _thresholdAverageHandlingTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageHandlingTimeRedSpecified { get; set; }
        
        private int _thresholdAverageSpeedOfAnswerYellow;

        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageSpeedOfAnswerYellow {
            get => _thresholdAverageSpeedOfAnswerYellow;
            set {
                ThresholdAverageSpeedOfAnswerYellowSpecified = true;
                _thresholdAverageSpeedOfAnswerYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageSpeedOfAnswerYellowSpecified { get; set; }
        
        private int _thresholdAverageSpeedOfAnswerRed;

        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageSpeedOfAnswerRed {
            get => _thresholdAverageSpeedOfAnswerRed;
            set {
                ThresholdAverageSpeedOfAnswerRedSpecified = true;
                _thresholdAverageSpeedOfAnswerRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageSpeedOfAnswerRedSpecified { get; set; }
        
        private bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        public bool EnableNotificationEmail {
            get => _enableNotificationEmail;
            set {
                EnableNotificationEmailSpecified = true;
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        public bool EnableNotificationEmailSpecified { get; set; }
        
        private List<string> _notificationEmailAddress;

        [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false, Namespace = "")]
        public List<string> NotificationEmailAddress {
            get => _notificationEmailAddress;
            set {
                NotificationEmailAddressSpecified = true;
                _notificationEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool NotificationEmailAddressSpecified { get; set; }
        
    }
}
