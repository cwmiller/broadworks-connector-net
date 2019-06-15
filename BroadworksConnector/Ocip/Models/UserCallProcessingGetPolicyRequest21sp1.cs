using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse21sp1 or an
    /// ErrorResponse.
    /// Replaced by: UserCallProcessingGetPolicyRequest21sp2
        /// <see cref="UserCallProcessingGetPolicyResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallProcessingGetPolicyRequest21sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallProcessingGetPolicyRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
    }
}
