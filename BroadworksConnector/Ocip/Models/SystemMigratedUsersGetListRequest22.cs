using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of migrated users.
    /// If the optional parameter userListSizeLimit is set, then the list returned in the response will contain entries up to value of userListSizeLimit.
    /// The response is either SystemMigratedUsersGetListResponse22 or ErrorResponse.
        /// <see cref="SystemMigratedUsersGetListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMigratedUsersGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _userListSizeLimit;

        [XmlElement(ElementName = "userListSizeLimit", IsNullable = false, Namespace = "")]
        public int UserListSizeLimit {
            get => _userListSizeLimit;
            set {
                UserListSizeLimitSpecified = true;
                _userListSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool UserListSizeLimitSpecified { get; set; }
        
    }
}
