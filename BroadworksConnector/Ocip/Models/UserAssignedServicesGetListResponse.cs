using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAssignedServicesGetListRequest.
    /// A user can have both user services and group services because of music on hold.
        /// <see cref="UserAssignedServicesGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAssignedServicesGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.AssignedGroupServicesEntry> _groupServiceEntry;

        [XmlElement(ElementName = "groupServiceEntry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AssignedGroupServicesEntry> GroupServiceEntry {
            get => _groupServiceEntry;
            set {
                GroupServiceEntrySpecified = true;
                _groupServiceEntry = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceEntrySpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.AssignedUserServicesEntry> _userServiceEntry;

        [XmlElement(ElementName = "userServiceEntry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AssignedUserServicesEntry> UserServiceEntry {
            get => _userServiceEntry;
            set {
                UserServiceEntrySpecified = true;
                _userServiceEntry = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceEntrySpecified { get; set; }
        
    }
}
