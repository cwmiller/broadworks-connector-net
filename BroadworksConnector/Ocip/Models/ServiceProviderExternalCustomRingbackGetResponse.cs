using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderExternalCustomRingbackGetRequest.
    /// <see cref="ServiceProviderExternalCustomRingbackGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8df43dca23d99d8ab44c0082aadfbe0:61""}]")]
    public class ServiceProviderExternalCustomRingbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:61")]
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
        protected bool PrefixDigitsSpecified { get; set; }

        protected string _serverNetAddress;

        [XmlElement(ElementName = "serverNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:61")]
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
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:61")]
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

        protected int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:61")]
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
        protected bool TimeoutSecondsSpecified { get; set; }

    }
}
