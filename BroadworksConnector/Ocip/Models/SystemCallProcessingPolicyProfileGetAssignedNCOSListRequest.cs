using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
    /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
    /// ErrorResponse.
        /// <see cref="SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        public string ProfileName {
            get => _profileName;
            set {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }
        
    }
}
