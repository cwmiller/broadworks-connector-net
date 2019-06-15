using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Policies.
    /// The response is either a UserCallPoliciesGetResponse17
    /// or an ErrorResponse.
    /// 
    /// Replaced by: UserCallPoliciesGetRequest19sp1 in AS data mode
        /// <see cref="UserCallPoliciesGetResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallPoliciesGetRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallPoliciesGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
