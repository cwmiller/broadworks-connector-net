using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Find-me/Follow-me instance.
    /// The response is either GroupFindMeFollowMeGetInstanceResponse or ErrorResponse.
    /// Replaced by: GroupFindMeFollowMeGetInstanceRequest19sp1
        /// <see cref="GroupFindMeFollowMeGetInstanceResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupFindMeFollowMeGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFindMeFollowMeGetInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
