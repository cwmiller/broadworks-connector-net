using System;
using System.Xml.Serialization;
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
     
    public class UserChargeNumberModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private bool _useChargeNumberForEnhancedTranslations;

        [XmlElement(ElementName = "useChargeNumberForEnhancedTranslations", IsNullable = false, Namespace = "")]
        public bool UseChargeNumberForEnhancedTranslations {
            get => _useChargeNumberForEnhancedTranslations;
            set {
                UseChargeNumberForEnhancedTranslationsSpecified = true;
                _useChargeNumberForEnhancedTranslations = value;
            }
        }

        [XmlIgnore]
        public bool UseChargeNumberForEnhancedTranslationsSpecified { get; set; }
        
        private bool _sendChargeNumberToNetwork;

        [XmlElement(ElementName = "sendChargeNumberToNetwork", IsNullable = false, Namespace = "")]
        public bool SendChargeNumberToNetwork {
            get => _sendChargeNumberToNetwork;
            set {
                SendChargeNumberToNetworkSpecified = true;
                _sendChargeNumberToNetwork = value;
            }
        }

        [XmlIgnore]
        public bool SendChargeNumberToNetworkSpecified { get; set; }
        
    }
}
