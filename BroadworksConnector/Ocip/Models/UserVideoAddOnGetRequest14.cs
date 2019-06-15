using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's Video Add-On service setting.
    /// The response is either a UserVideoAddOnGetResponse14 or an ErrorResponse.
    /// 
    /// Replaced by: UserVideoAddOnGetRequest19.
        /// <see cref="UserVideoAddOnGetResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserVideoAddOnGetRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVideoAddOnGetRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
