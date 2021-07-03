using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16.
    /// 
    /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 in AS data mode
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16"/>
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4020""}]")]
    public class GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

        [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _voicePortalGreetingMediaType;

        [XmlElement(ElementName = "voicePortalGreetingMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaType
        {
            get => _voicePortalGreetingMediaType;
            set
            {
                VoicePortalGreetingMediaTypeSpecified = true;
                _voicePortalGreetingMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

        [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _voiceMessagingGreetingMediaType;

        [XmlElement(ElementName = "voiceMessagingGreetingMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4020")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaType
        {
            get => _voiceMessagingGreetingMediaType;
            set
            {
                VoiceMessagingGreetingMediaTypeSpecified = true;
                _voiceMessagingGreetingMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingMediaTypeSpecified { get; set; }

    }
}
