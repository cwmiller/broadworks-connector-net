using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Processing Policy.
    /// The response is either a UserCallProcessingGetPolicyResponse17sp4 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: UserCallProcessingGetPolicyRequest18
        /// <see cref="UserCallProcessingGetPolicyResponse17sp4"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallProcessingGetPolicyRequest18"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallProcessingGetPolicyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
