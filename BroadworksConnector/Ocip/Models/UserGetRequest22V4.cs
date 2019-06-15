using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the user information.  The response is either UserGetResponse22V4 or ErrorResponse.
    /// 
    /// Replaced by: UserGetResponse22V5 in AS data mode
        /// <see cref="UserGetResponse22V4"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserGetResponse22V5"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetRequest22V4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
