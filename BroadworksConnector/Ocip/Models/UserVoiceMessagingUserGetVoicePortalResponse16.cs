using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserVoiceMessagingUserGetVoicePortalRequest16.
    /// <see cref="UserVoiceMessagingUserGetVoicePortalRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8b2edcd7d6936a8b76653949ae59623:500""}]")]
    public class UserVoiceMessagingUserGetVoicePortalResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _usePersonalizedName;

        [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:500")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:500")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:500")]
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _personalizedNameMediaType;

        [XmlElement(ElementName = "personalizedNameMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:500")]
        public BroadWorksConnector.Ocip.Models.MediaFileType PersonalizedNameMediaType
        {
            get => _personalizedNameMediaType;
            set
            {
                PersonalizedNameMediaTypeSpecified = true;
                _personalizedNameMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameMediaTypeSpecified { get; set; }

    }
}
