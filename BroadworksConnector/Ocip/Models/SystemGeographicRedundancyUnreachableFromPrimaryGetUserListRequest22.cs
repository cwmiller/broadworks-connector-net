using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of users that are unreachable from the primary application server.
    /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 or an ErrorResponse.
        /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
