using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the list of Peer SIP Connection Monitoring system parameters
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10655""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10655")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected int _heartbeatInterval;

        [XmlElement(ElementName = "heartbeatInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10655")]
        [MinInclusive(10)]
        [MaxInclusive(3600000)]
        public int HeartbeatInterval
        {
            get => _heartbeatInterval;
            set
            {
                HeartbeatIntervalSpecified = true;
                _heartbeatInterval = value;
            }
        }

        [XmlIgnore]
        protected bool HeartbeatIntervalSpecified { get; set; }

        protected int _heartbeatTimeout;

        [XmlElement(ElementName = "heartbeatTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10655")]
        [MinInclusive(10)]
        [MaxInclusive(18000000)]
        public int HeartbeatTimeout
        {
            get => _heartbeatTimeout;
            set
            {
                HeartbeatTimeoutSpecified = true;
                _heartbeatTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool HeartbeatTimeoutSpecified { get; set; }

    }
}
