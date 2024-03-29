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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2c9f194a3272e429f2e5215dd988b94a:80""}]")]
    public class ServiceProviderExternalCustomRingbackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"2c9f194a3272e429f2e5215dd988b94a:80")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"2c9f194a3272e429f2e5215dd988b94a:80")]
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

        [XmlElement(ElementName = "serverNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"2c9f194a3272e429f2e5215dd988b94a:80")]
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
        [Group(@"2c9f194a3272e429f2e5215dd988b94a:80")]
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

        protected int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2c9f194a3272e429f2e5215dd988b94a:80")]
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
