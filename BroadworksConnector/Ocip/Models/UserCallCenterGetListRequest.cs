using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of call centers the specified user belongs to.
    /// The response is either a UserCallCenterGetListResponse or an ErrorResponse.
    /// Replaced By: UserCallCenterGetRequest
        /// <see cref="UserCallCenterGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallCenterGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
