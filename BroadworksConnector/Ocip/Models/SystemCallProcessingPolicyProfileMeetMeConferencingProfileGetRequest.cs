using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber
    /// type profile.
    /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22
        /// <see cref="SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        public string CallProcessingPolicyProfileName {
            get => _callProcessingPolicyProfileName;
            set {
                CallProcessingPolicyProfileNameSpecified = true;
                _callProcessingPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        public bool CallProcessingPolicyProfileNameSpecified { get; set; }
        
    }
}
