using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group's voice portal branding settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1049""}]")]
    public class GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

        [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _voicePortalGreetingFile;

        [XmlElement(ElementName = "voicePortalGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VoicePortalGreetingFile
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

        [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _voiceMessagingGreetingFile;

        [XmlElement(ElementName = "voiceMessagingGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1049")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VoiceMessagingGreetingFile
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
