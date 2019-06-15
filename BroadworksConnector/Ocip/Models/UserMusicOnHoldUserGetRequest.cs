using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Music On Hold User.
    /// The response is either a UserMusicOnHoldUserGetResponse or an ErrorResponse.
    /// Replaced By: UserMusicOnHoldUserGetRequest16
        /// <see cref="UserMusicOnHoldUserGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserMusicOnHoldUserGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMusicOnHoldUserGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
