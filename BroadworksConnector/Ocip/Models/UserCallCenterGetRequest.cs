using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's ACD state and the list of call centers the specified user belongs to.
    /// The response is either a UserCallCenterGetResponse or an ErrorResponse.
    /// 
    /// Replaced By: UserCallCenterGetRequest16
        /// <see cref="UserCallCenterGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallCenterGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
