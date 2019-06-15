using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the group voice portal information for a voice messaging group.
    /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 or ErrorResponse.
    /// 
    /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 in AS data mode.
        /// <see cref="GroupVoiceMessagingGroupGetVoicePortalResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupVoiceMessagingGroupGetVoicePortalRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
