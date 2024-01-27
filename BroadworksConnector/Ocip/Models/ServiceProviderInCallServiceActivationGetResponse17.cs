using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderInCallServiceActivationGetRequest17.
    /// <see cref="ServiceProviderInCallServiceActivationGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2f2cc47dc637fa680d158d93a58af0fd:61""}]")]
    public class ServiceProviderInCallServiceActivationGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _flashActivationDigits;

        [XmlElement(ElementName = "flashActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"2f2cc47dc637fa680d158d93a58af0fd:61")]
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
        [Group(@"2f2cc47dc637fa680d158d93a58af0fd:61")]
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
