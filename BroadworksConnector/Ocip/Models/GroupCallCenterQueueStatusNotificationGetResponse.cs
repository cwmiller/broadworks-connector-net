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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:5677""}]")]
    public class GroupCallCenterQueueStatusNotificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableQueueStatusNotification;

        [XmlElement(ElementName = "enableQueueStatusNotification", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5677")]
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

        protected bool _enableQueueDepthThreshold;

        [XmlElement(ElementName = "enableQueueDepthThreshold", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5677")]
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

        protected bool _enableWaitingTimeThreshold;

        [XmlElement(ElementName = "enableWaitingTimeThreshold", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5677")]
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

        protected int _numberOfCallsThreshold;

        [XmlElement(ElementName = "numberOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5677")]
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

        protected int _waitingTimeOfCallsThreshold;

        [XmlElement(ElementName = "waitingTimeOfCallsThreshold", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:5677")]
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
