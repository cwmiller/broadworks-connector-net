using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16.
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:426""}]")]
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

        [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection
        {
            get => _voicePortalGreetingSelection;
            set
            {
                VoicePortalGreetingSelectionSpecified = true;
                _voicePortalGreetingSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingSelectionSpecified { get; set; }

        private string _voicePortalGreetingFileDescription;

        [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VoicePortalGreetingFileDescription
        {
            get => _voicePortalGreetingFileDescription;
            set
            {
                VoicePortalGreetingFileDescriptionSpecified = true;
                _voicePortalGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _voicePortalGreetingMediaFileType;

        [XmlElement(ElementName = "voicePortalGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaFileType
        {
            get => _voicePortalGreetingMediaFileType;
            set
            {
                VoicePortalGreetingMediaFileTypeSpecified = true;
                _voicePortalGreetingMediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingMediaFileTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

        [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection
        {
            get => _voiceMessagingGreetingSelection;
            set
            {
                VoiceMessagingGreetingSelectionSpecified = true;
                _voiceMessagingGreetingSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingSelectionSpecified { get; set; }

        private string _voiceMessagingGreetingFileDescription;

        [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VoiceMessagingGreetingFileDescription
        {
            get => _voiceMessagingGreetingFileDescription;
            set
            {
                VoiceMessagingGreetingFileDescriptionSpecified = true;
                _voiceMessagingGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _voiceMessagingGreetingMediaFileType;

        [XmlElement(ElementName = "voiceMessagingGreetingMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:426")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaFileType
        {
            get => _voiceMessagingGreetingMediaFileType;
            set
            {
                VoiceMessagingGreetingMediaFileTypeSpecified = true;
                _voiceMessagingGreetingMediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingMediaFileTypeSpecified { get; set; }

    }
}
