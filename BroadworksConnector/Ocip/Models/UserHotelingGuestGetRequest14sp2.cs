using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Hoteling Guest.
    /// The response is either a UserHotelingGuestGetResponse14 or an ErrorResponse.
    /// Replaced by: UserHotelingGuestGetRequest14sp4
        /// <see cref="UserHotelingGuestGetResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserHotelingGuestGetRequest14sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserHotelingGuestGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
