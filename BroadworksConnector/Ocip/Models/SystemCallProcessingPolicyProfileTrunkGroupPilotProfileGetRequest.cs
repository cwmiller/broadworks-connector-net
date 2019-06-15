using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber
    /// type profile.
    /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22
        /// <see cref="SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
