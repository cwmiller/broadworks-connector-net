using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP specific service attribute for the user.
    /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
    /// 
    /// Replaced by: UserIntegratedIMPGetRequest21sp1
        /// <see cref="UserIntegratedIMPGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserIntegratedIMPGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserIntegratedIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
