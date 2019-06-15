using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's call center settings and the list of call centers the specified user belongs to.
    /// The response is either a UserCallCenterGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by UserCallCenterGetRequest17sp4.
        /// <see cref="UserCallCenterGetResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallCenterGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
