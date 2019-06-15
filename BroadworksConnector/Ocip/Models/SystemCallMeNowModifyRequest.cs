using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallMeNowModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _passcodeLength;

        [XmlElement(ElementName = "passcodeLength", IsNullable = false, Namespace = "")]
        public int PasscodeLength {
            get => _passcodeLength;
            set {
                PasscodeLengthSpecified = true;
                _passcodeLength = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeLengthSpecified { get; set; }
        
        private int _passcodeTimeoutSeconds;

        [XmlElement(ElementName = "passcodeTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int PasscodeTimeoutSeconds {
            get => _passcodeTimeoutSeconds;
            set {
                PasscodeTimeoutSecondsSpecified = true;
                _passcodeTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeTimeoutSecondsSpecified { get; set; }
        
    }
}
