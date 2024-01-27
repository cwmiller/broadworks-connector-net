using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest.
    /// Contains a list of Peer SIP Connection Monitoring system parameters.
    /// <see cref="SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10637""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10637")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:10637")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:10637")]
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
