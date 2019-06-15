using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the speed dial 100 settings for a user.
    /// The response is either a UserSpeedDial100GetListResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserSpeedDial100GetListRequest17Sp1
        /// <see cref="UserSpeedDial100GetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSpeedDial100GetListRequest17Sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSpeedDial100GetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
