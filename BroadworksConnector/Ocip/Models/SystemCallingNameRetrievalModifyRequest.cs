using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's calling name retrieval attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallingNameRetrievalModifyRequest16sp1
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallingNameRetrievalModifyRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21935""}]")]
    public class SystemCallingNameRetrievalModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _queryTimerMilliSeconds;

        [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21935")]
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

        [XmlElement(ElementName = "serverNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21935")]
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

        protected int? _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21935")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? ServerPort
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
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21935")]
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
