using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserVoiceMessagingUserGetVoicePortalRequest.
    /// Replaced By: UserVoiceMessagingUserGetVoicePortalResponse16
        /// <see cref="UserVoiceMessagingUserGetVoicePortalRequest"/>
        /// <see cref="UserVoiceMessagingUserGetVoicePortalResponse16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetVoicePortalResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private string _personalizedNameAudioFileDescription;

        [XmlElement(ElementName = "personalizedNameAudioFileDescription", IsNullable = false, Namespace = "")]
        public string PersonalizedNameAudioFileDescription {
            get => _personalizedNameAudioFileDescription;
            set {
                PersonalizedNameAudioFileDescriptionSpecified = true;
                _personalizedNameAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool PersonalizedNameAudioFileDescriptionSpecified { get; set; }
        
    }
}
