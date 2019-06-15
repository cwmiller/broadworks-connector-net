using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the group's voice portal branding settings.
    /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
    /// 
    /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 in AS data mode
        /// <see cref="GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
    }
}
