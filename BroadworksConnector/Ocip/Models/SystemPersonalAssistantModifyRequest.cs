using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Personal Assistant Parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPersonalAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _transferToAttendantKey;

        [XmlElement(ElementName = "transferToAttendantKey", IsNullable = false, Namespace = "")]
        public string TransferToAttendantKey {
            get => _transferToAttendantKey;
            set {
                TransferToAttendantKeySpecified = true;
                _transferToAttendantKey = value;
            }
        }

        [XmlIgnore]
        public bool TransferToAttendantKeySpecified { get; set; }
        
        private string _transferToVoiceMessagingKey;

        [XmlElement(ElementName = "transferToVoiceMessagingKey", IsNullable = false, Namespace = "")]
        public string TransferToVoiceMessagingKey {
            get => _transferToVoiceMessagingKey;
            set {
                TransferToVoiceMessagingKeySpecified = true;
                _transferToVoiceMessagingKey = value;
            }
        }

        [XmlIgnore]
        public bool TransferToVoiceMessagingKeySpecified { get; set; }
        
    }
}
