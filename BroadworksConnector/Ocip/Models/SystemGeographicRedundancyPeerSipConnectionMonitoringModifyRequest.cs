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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10537""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10537")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10537")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10537")]
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
