using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemASRParametersGetRequest14sp7.
    /// Contains a list of system Application Server Registration parameters.
    /// <see cref="SystemASRParametersGetRequest14sp7"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1944""}]")]
    public class SystemASRParametersGetResponse14sp7 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1944")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1944")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1944")]
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

    }
}
