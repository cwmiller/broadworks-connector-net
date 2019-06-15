using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a user's Security Classifications configuration.
    /// The response is either UserSecurityClassificationGetResponse or ErrorResponse.
    /// 
    /// Replaced By: UserSecurityClassificationGetRequest22.
        /// <see cref="UserSecurityClassificationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSecurityClassificationGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSecurityClassificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
