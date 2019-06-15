using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
    /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
    /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
        /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksAnywhereGetAvailablePortalListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
