using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Charge Number.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e1ee26e6fdadbb813e9077c4ea7fd6d1:74""}]")]
    public class UserChargeNumberModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:74")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:74")]
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
        [Optional]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:74")]
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
        [Optional]
        [Group(@"e1ee26e6fdadbb813e9077c4ea7fd6d1:74")]
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
