using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the service provider's DTMF based in-call service activation trigger attributes.The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2f2cc47dc637fa680d158d93a58af0fd:77""}]")]
    public class ServiceProviderInCallServiceActivationModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"2f2cc47dc637fa680d158d93a58af0fd:77")]
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

        protected string _flashActivationDigits;

        [XmlElement(ElementName = "flashActivationDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2f2cc47dc637fa680d158d93a58af0fd:77")]
        [MinLength(1)]
        [MaxLength(8)]
        public string FlashActivationDigits
        {
            get => _flashActivationDigits;
            set
            {
                FlashActivationDigitsSpecified = true;
                _flashActivationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool FlashActivationDigitsSpecified { get; set; }

        protected string _callTransferActivationDigits;

        [XmlElement(ElementName = "callTransferActivationDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2f2cc47dc637fa680d158d93a58af0fd:77")]
        [MinLength(1)]
        [MaxLength(8)]
        public string CallTransferActivationDigits
        {
            get => _callTransferActivationDigits;
            set
            {
                CallTransferActivationDigitsSpecified = true;
                _callTransferActivationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool CallTransferActivationDigitsSpecified { get; set; }

    }
}
