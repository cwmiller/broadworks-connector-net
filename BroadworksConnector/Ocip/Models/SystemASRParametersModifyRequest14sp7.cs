using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Application Server Registration system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// enableCustomMessageControl
    /// customNumberOfUsersPerMessage
    /// customMessageIntervalMilliseconds
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2470""}]")]
    public class SystemASRParametersModifyRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxTransmissions
        {
            get => _maxTransmissions;
            set
            {
                MaxTransmissionsSpecified = true;
                _maxTransmissions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTransmissionsSpecified { get; set; }

        protected int _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        [MinInclusive(100)]
        [MaxInclusive(2000)]
        public int RetransmissionDelayMilliSeconds
        {
            get => _retransmissionDelayMilliSeconds;
            set
            {
                RetransmissionDelayMilliSecondsSpecified = true;
                _retransmissionDelayMilliSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RetransmissionDelayMilliSecondsSpecified { get; set; }

        protected int _listeningPort;

        [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ListeningPort
        {
            get => _listeningPort;
            set
            {
                ListeningPortSpecified = true;
                _listeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool ListeningPortSpecified { get; set; }

        protected bool _enableCustomMessageControl;

        [XmlElement(ElementName = "enableCustomMessageControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        public bool EnableCustomMessageControl
        {
            get => _enableCustomMessageControl;
            set
            {
                EnableCustomMessageControlSpecified = true;
                _enableCustomMessageControl = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCustomMessageControlSpecified { get; set; }

        protected int _customNumberOfUsersPerMessage;

        [XmlElement(ElementName = "customNumberOfUsersPerMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int CustomNumberOfUsersPerMessage
        {
            get => _customNumberOfUsersPerMessage;
            set
            {
                CustomNumberOfUsersPerMessageSpecified = true;
                _customNumberOfUsersPerMessage = value;
            }
        }

        [XmlIgnore]
        protected bool CustomNumberOfUsersPerMessageSpecified { get; set; }

        protected int _customMessageIntervalMilliseconds;

        [XmlElement(ElementName = "customMessageIntervalMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2470")]
        [MinInclusive(50)]
        [MaxInclusive(1000)]
        public int CustomMessageIntervalMilliseconds
        {
            get => _customMessageIntervalMilliseconds;
            set
            {
                CustomMessageIntervalMillisecondsSpecified = true;
                _customMessageIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool CustomMessageIntervalMillisecondsSpecified { get; set; }

    }
}
