using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47185""}]")]
    public class UserVoiceMessagingUserGetVoicePortalResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _usePersonalizedName;

        [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47185")]
        public bool UsePersonalizedName
        {
            get => _usePersonalizedName;
            set
            {
                UsePersonalizedNameSpecified = true;
                _usePersonalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool UsePersonalizedNameSpecified { get; set; }

        private bool _voicePortalAutoLogin;

        [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47185")]
        public bool VoicePortalAutoLogin
        {
            get => _voicePortalAutoLogin;
            set
            {
                VoicePortalAutoLoginSpecified = true;
                _voicePortalAutoLogin = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalAutoLoginSpecified { get; set; }

        private string _personalizedNameAudioFileDescription;

        [XmlElement(ElementName = "personalizedNameAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47185")]
        [MinLength(1)]
        [MaxLength(256)]
        public string PersonalizedNameAudioFileDescription
        {
            get => _personalizedNameAudioFileDescription;
            set
            {
                PersonalizedNameAudioFileDescriptionSpecified = true;
                _personalizedNameAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameAudioFileDescriptionSpecified { get; set; }

    }
}
