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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ece0b65e69189d3e8b8deee895f0a7ff:61""}]")]
    public class ServiceProviderInCallServiceActivationGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _flashActivationDigits;

        [XmlElement(ElementName = "flashActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"ece0b65e69189d3e8b8deee895f0a7ff:61")]
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
        public bool FlashActivationDigitsSpecified { get; set; }

        private string _callTransferActivationDigits;

        [XmlElement(ElementName = "callTransferActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"ece0b65e69189d3e8b8deee895f0a7ff:61")]
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
        public bool CallTransferActivationDigitsSpecified { get; set; }

    }
}
