using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemASRParametersGetRequest23.
    /// Contains a list of system Application Server Registration parameters.
    /// 
    /// The following elements are only used in AS data mode:
    /// enableCustomMessageControl, value "false" is returned in XS data mode
    /// customNumberOfUsersPerMessage, value "10" is returned in XS data mode
    /// customMessageIntervalMilliseconds, value "100000" is returned in XS data mode
    /// <see cref="SystemASRParametersGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2444""}]")]
    public class SystemASRParametersGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2444")]
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
