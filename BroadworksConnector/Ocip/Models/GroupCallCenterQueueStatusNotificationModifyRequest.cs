using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Set the status configuration for a given call center.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5739""}]")]
    public class GroupCallCenterQueueStatusNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
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
        public bool ServiceUserIdSpecified { get; set; }

        private bool _enableQueueStatusNotification;

        [XmlElement(ElementName = "enableQueueStatusNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
        public bool EnableQueueStatusNotification
        {
            get => _enableQueueStatusNotification;
            set
            {
                EnableQueueStatusNotificationSpecified = true;
                _enableQueueStatusNotification = value;
            }
        }

        [XmlIgnore]
        public bool EnableQueueStatusNotificationSpecified { get; set; }

        private bool _enableQueueDepthThreshold;

        [XmlElement(ElementName = "enableQueueDepthThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
        public bool EnableQueueDepthThreshold
        {
            get => _enableQueueDepthThreshold;
            set
            {
                EnableQueueDepthThresholdSpecified = true;
                _enableQueueDepthThreshold = value;
            }
        }

        [XmlIgnore]
        public bool EnableQueueDepthThresholdSpecified { get; set; }

        private bool _enableWaitingTimeThreshold;

        [XmlElement(ElementName = "enableWaitingTimeThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
        public bool EnableWaitingTimeThreshold
        {
            get => _enableWaitingTimeThreshold;
            set
            {
                EnableWaitingTimeThresholdSpecified = true;
                _enableWaitingTimeThreshold = value;
            }
        }

        [XmlIgnore]
        public bool EnableWaitingTimeThresholdSpecified { get; set; }

        private int _numberOfCallsThreshold;

        [XmlElement(ElementName = "numberOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
        [MinInclusive(1)]
        [MaxInclusive(525)]
        public int NumberOfCallsThreshold
        {
            get => _numberOfCallsThreshold;
            set
            {
                NumberOfCallsThresholdSpecified = true;
                _numberOfCallsThreshold = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfCallsThresholdSpecified { get; set; }

        private int _waitingTimeOfCallsThreshold;

        [XmlElement(ElementName = "waitingTimeOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5739")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public int WaitingTimeOfCallsThreshold
        {
            get => _waitingTimeOfCallsThreshold;
            set
            {
                WaitingTimeOfCallsThresholdSpecified = true;
                _waitingTimeOfCallsThreshold = value;
            }
        }

        [XmlIgnore]
        public bool WaitingTimeOfCallsThresholdSpecified { get; set; }

    }
}
