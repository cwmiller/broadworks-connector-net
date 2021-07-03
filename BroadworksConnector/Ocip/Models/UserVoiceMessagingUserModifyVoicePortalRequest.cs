using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging voice portal settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// Replaced By: UserVoiceMessagingUserModifyVoicePortalRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserModifyVoicePortalRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47325""}]")]
    public class UserVoiceMessagingUserModifyVoicePortalRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47325")]
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

        private bool _usePersonalizedName;

        [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47325")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47325")]
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _personalizedNameAudioFile;

        [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47325")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource PersonalizedNameAudioFile
        {
            get => _personalizedNameAudioFile;
            set
            {
                PersonalizedNameAudioFileSpecified = true;
                _personalizedNameAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameAudioFileSpecified { get; set; }

    }
}
