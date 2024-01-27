using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserChargeNumberGetRequest14sp9.
    /// <see cref="UserChargeNumberGetRequest14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e1ee26e6fdadbb813e9077c4ea7fd6d1:56""}]")]
    public class UserChargeNumberGetResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:56")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        protected bool _useChargeNumberForEnhancedTranslations;

        [XmlElement(ElementName = "useChargeNumberForEnhancedTranslations", IsNullable = false, Namespace = "")]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:56")]
        public bool UseChargeNumberForEnhancedTranslations
        {
            get => _useChargeNumberForEnhancedTranslations;
            set
            {
                UseChargeNumberForEnhancedTranslationsSpecified = true;
                _useChargeNumberForEnhancedTranslations = value;
            }
        }

        [XmlIgnore]
        protected bool UseChargeNumberForEnhancedTranslationsSpecified { get; set; }

        protected bool _sendChargeNumberToNetwork;

        [XmlElement(ElementName = "sendChargeNumberToNetwork", IsNullable = false, Namespace = "")]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:56")]
        public bool SendChargeNumberToNetwork
        {
            get => _sendChargeNumberToNetwork;
            set
            {
                SendChargeNumberToNetworkSpecified = true;
                _sendChargeNumberToNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool SendChargeNumberToNetworkSpecified { get; set; }

    }
}
