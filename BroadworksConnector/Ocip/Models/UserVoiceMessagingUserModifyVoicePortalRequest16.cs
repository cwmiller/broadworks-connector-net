using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging voice portal settings.
    /// The response is either a SuccessResponse
    /// or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserModifyVoicePortalRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _usePersonalizedName;

        [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
        public bool UsePersonalizedName {
            get => _usePersonalizedName;
            set {
                UsePersonalizedNameSpecified = true;
                _usePersonalizedName = value;
            }
        }

        [XmlIgnore]
        public bool UsePersonalizedNameSpecified { get; set; }
        
        private bool _voicePortalAutoLogin;

        [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false, Namespace = "")]
        public bool VoicePortalAutoLogin {
            get => _voicePortalAutoLogin;
            set {
                VoicePortalAutoLoginSpecified = true;
                _voicePortalAutoLogin = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalAutoLoginSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _personalizedNameAudioFile;

        [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource PersonalizedNameAudioFile {
            get => _personalizedNameAudioFile;
            set {
                PersonalizedNameAudioFileSpecified = true;
                _personalizedNameAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool PersonalizedNameAudioFileSpecified { get; set; }
        
    }
}
