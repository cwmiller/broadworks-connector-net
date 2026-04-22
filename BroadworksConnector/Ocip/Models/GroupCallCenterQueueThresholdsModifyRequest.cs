using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's queue Thresholds settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5761""}]")]
    public class GroupCallCenterQueueThresholdsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool? _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        public bool? IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = (value != null);
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected int? _thresholdCurrentCallsInQueueYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallsInQueueYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(525)]
        public int? ThresholdCurrentCallsInQueueYellow
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

        protected int? _thresholdCurrentCallsInQueueRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallsInQueueRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(525)]
        public int? ThresholdCurrentCallsInQueueRed
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

        protected int? _thresholdCurrentLongestWaitingCallYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentLongestWaitingCallYellow
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

        protected int? _thresholdCurrentLongestWaitingCallRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentLongestWaitingCallRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentLongestWaitingCallRed
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

        protected int? _thresholdAverageEstimatedWaitTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageEstimatedWaitTimeYellow
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

        protected int? _thresholdAverageEstimatedWaitTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageEstimatedWaitTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageEstimatedWaitTimeRed
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

        protected int? _thresholdAverageHandlingTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageHandlingTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageHandlingTimeYellow
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

        protected int? _thresholdAverageHandlingTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageHandlingTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageHandlingTimeRed
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

        protected int? _thresholdAverageSpeedOfAnswerYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageSpeedOfAnswerYellow
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

        protected int? _thresholdAverageSpeedOfAnswerRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageSpeedOfAnswerRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageSpeedOfAnswerRed
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

        protected bool? _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        public bool? EnableNotificationEmail
        {
            get => _enableNotificationEmail;
            set
            {
                EnableNotificationEmailSpecified = (value != null);
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotificationEmailSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterQueueThresholdReplacementNotificationEmailList _notificationEmailAddressList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5761")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueThresholdReplacementNotificationEmailList NotificationEmailAddressList
        {
            get => _notificationEmailAddressList;
            set
            {
                NotificationEmailAddressListSpecified = true;
                _notificationEmailAddressList = value;
            }
        }

        [XmlIgnore]
        protected bool NotificationEmailAddressListSpecified { get; set; }

    }
}
