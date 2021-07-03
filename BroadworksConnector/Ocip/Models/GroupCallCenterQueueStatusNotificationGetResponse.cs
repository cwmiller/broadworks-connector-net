using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterQueueStatusNotificationGetRequest.
    /// The response contains the call center status configuration information.
    /// <see cref="GroupCallCenterQueueStatusNotificationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5681""}]")]
    public class GroupCallCenterQueueStatusNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableQueueStatusNotification;

        [XmlElement(ElementName = "enableQueueStatusNotification", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5681")]
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
        protected bool EnableQueueStatusNotificationSpecified { get; set; }

        private bool _enableQueueDepthThreshold;

        [XmlElement(ElementName = "enableQueueDepthThreshold", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5681")]
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
        protected bool EnableQueueDepthThresholdSpecified { get; set; }

        private bool _enableWaitingTimeThreshold;

        [XmlElement(ElementName = "enableWaitingTimeThreshold", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5681")]
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
        protected bool EnableWaitingTimeThresholdSpecified { get; set; }

        private int _numberOfCallsThreshold;

        [XmlElement(ElementName = "numberOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5681")]
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
        protected bool NumberOfCallsThresholdSpecified { get; set; }

        private int _waitingTimeOfCallsThreshold;

        [XmlElement(ElementName = "waitingTimeOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5681")]
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
        protected bool WaitingTimeOfCallsThresholdSpecified { get; set; }

    }
}
