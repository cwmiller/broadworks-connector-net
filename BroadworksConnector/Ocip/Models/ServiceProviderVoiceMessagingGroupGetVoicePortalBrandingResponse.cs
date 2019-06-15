using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest.
    /// Replaced By: ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16
        /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest"/>
        /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voicePortalGreetingSelection;

        [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection {
            get => _voicePortalGreetingSelection;
            set {
                VoicePortalGreetingSelectionSpecified = true;
                _voicePortalGreetingSelection = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalGreetingSelectionSpecified { get; set; }
        
        private string _voicePortalGreetingFileDescription;

        [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false, Namespace = "")]
        public string VoicePortalGreetingFileDescription {
            get => _voicePortalGreetingFileDescription;
            set {
                VoicePortalGreetingFileDescriptionSpecified = true;
                _voicePortalGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalGreetingFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection _voiceMessagingGreetingSelection;

        [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection {
            get => _voiceMessagingGreetingSelection;
            set {
                VoiceMessagingGreetingSelectionSpecified = true;
                _voiceMessagingGreetingSelection = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessagingGreetingSelectionSpecified { get; set; }
        
        private string _voiceMessagingGreetingFileDescription;

        [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false, Namespace = "")]
        public string VoiceMessagingGreetingFileDescription {
            get => _voiceMessagingGreetingFileDescription;
            set {
                VoiceMessagingGreetingFileDescriptionSpecified = true;
                _voiceMessagingGreetingFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessagingGreetingFileDescriptionSpecified { get; set; }
        
    }
}
