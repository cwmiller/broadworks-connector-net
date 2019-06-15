using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's intercept user service settings.
    /// The response is either a UserInterceptUserGetResponse16 or an ErrorResponse.
    /// Replaced By: UserInterceptUserGetRequest16sp1
        /// <see cref="UserInterceptUserGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserInterceptUserGetRequest16sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserInterceptUserGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
