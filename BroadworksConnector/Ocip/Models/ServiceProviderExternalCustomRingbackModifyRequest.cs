using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider level data associated with External Custom Ringback.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8df43dca23d99d8ab44c0082aadfbe0:80""}]")]
    public class ServiceProviderExternalCustomRingbackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:80")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:80")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PrefixDigits
        {
            get => _prefixDigits;
            set
            {
                PrefixDigitsSpecified = true;
                _prefixDigits = value;
            }
        }

        [XmlIgnore]
        public bool PrefixDigitsSpecified { get; set; }

        private string _serverNetAddress;

        [XmlElement(ElementName = "serverNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:80")]
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
        public bool ServerNetAddressSpecified { get; set; }

        private int? _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:80")]
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
        public bool ServerPortSpecified { get; set; }

        private int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:80")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int TimeoutSeconds
        {
            get => _timeoutSeconds;
            set
            {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutSecondsSpecified { get; set; }

    }
}
