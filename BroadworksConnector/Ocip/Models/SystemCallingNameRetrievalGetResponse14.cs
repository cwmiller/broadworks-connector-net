using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallingNameRetrievalGetRequest14.
    /// <see cref="SystemCallingNameRetrievalGetRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21836""}]")]
    public class SystemCallingNameRetrievalGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _queryTimerMilliSeconds;

        [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21836")]
        [MinInclusive(500)]
        [MaxInclusive(5000)]
        public int QueryTimerMilliSeconds
        {
            get => _queryTimerMilliSeconds;
            set
            {
                QueryTimerMilliSecondsSpecified = true;
                _queryTimerMilliSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool QueryTimerMilliSecondsSpecified { get; set; }

        protected string _serverNetAddress;

        [XmlElement(ElementName = "serverNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21836")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServerNetAddress
        {
            get => _serverNetAddress;
            set
            {
                ServerNetAddressSpecified = true;
                _serverNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ServerNetAddressSpecified { get; set; }

        protected int _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21836")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ServerPort
        {
            get => _serverPort;
            set
            {
                ServerPortSpecified = true;
                _serverPort = value;
            }
        }

        [XmlIgnore]
        protected bool ServerPortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TransportProtocol _serverTransportProtocol;

        [XmlElement(ElementName = "serverTransportProtocol", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21836")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol ServerTransportProtocol
        {
            get => _serverTransportProtocol;
            set
            {
                ServerTransportProtocolSpecified = true;
                _serverTransportProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool ServerTransportProtocolSpecified { get; set; }

    }
}
