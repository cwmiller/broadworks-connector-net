using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the Group administrator's policy settings.
    /// The response is either GroupAdminGetPolicyResponse16sp1 or ErrorResponse.
    /// Replaced by: GroupAdminGetPolicyRequest17
        /// <see cref="GroupAdminGetPolicyResponse16sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAdminGetPolicyRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAdminGetPolicyRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
