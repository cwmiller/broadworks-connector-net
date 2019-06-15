using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Music On Hold User.
    /// The response is either a UserMusicOnHoldUserGetResponse16 or an ErrorResponse.
    /// 
    /// Replaced by: UserMusicOnHoldUserGetRequest20 in AS data mode
        /// <see cref="UserMusicOnHoldUserGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserMusicOnHoldUserGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMusicOnHoldUserGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
