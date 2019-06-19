using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemASRParametersGetRequest14sp5.
    /// Contains a list of system Application Server Registration parameters.
    /// <see cref="SystemASRParametersGetRequest14sp5"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4227""}]")]
    public class SystemASRParametersGetResponse14sp5 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4227")]
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
        public bool MaxTransmissionsSpecified { get; set; }

        private int _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4227")]
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
        public bool RetransmissionDelayMilliSecondsSpecified { get; set; }

        private int _listeningPort;

        [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4227")]
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
        public bool ListeningPortSpecified { get; set; }

        private string _sourceAddress;

        [XmlElement(ElementName = "sourceAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4227")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SourceAddress
        {
            get => _sourceAddress;
            set
            {
                SourceAddressSpecified = true;
                _sourceAddress = value;
            }
        }

        [XmlIgnore]
        public bool SourceAddressSpecified { get; set; }

    }
}
