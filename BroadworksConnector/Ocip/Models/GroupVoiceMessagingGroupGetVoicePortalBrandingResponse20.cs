using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20.
    /// <see cref="GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:171""}]")]
    public class GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

        [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:171")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _voicePortalGreetingFile;

        [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:171")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VoicePortalGreetingFile
        {
            get => _voicePortalGreetingFile;
            set
            {
                VoicePortalGreetingFileSpecified = true;
                _voicePortalGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalGreetingFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

        [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:171")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _voiceMessagingGreetingFile;

        [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:171")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VoiceMessagingGreetingFile
        {
            get => _voiceMessagingGreetingFile;
            set
            {
                VoiceMessagingGreetingFileSpecified = true;
                _voiceMessagingGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGreetingFileSpecified { get; set; }

    }
}
