using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the collaborate bridged assigned to the user. The user can only be assigned to one collaborate
    /// bridge at any given time.
    /// The response is either UserCollaborateBridgeGetResponse or ErrorResponse.
    /// 
    /// Replaced by: UserCollaborateBridgeGetRequest20sp1
        /// <see cref="UserCollaborateBridgeGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCollaborateBridgeGetRequest20sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCollaborateBridgeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
