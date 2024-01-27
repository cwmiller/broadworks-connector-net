using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:840""}]")]
    public class UserAssignedServicesGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.AssignedGroupServicesEntry> _groupServiceEntry = new List<BroadWorksConnector.Ocip.Models.AssignedGroupServicesEntry>();

        [XmlElement(ElementName = "groupServiceEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:840")]
        public List<BroadWorksConnector.Ocip.Models.AssignedGroupServicesEntry> GroupServiceEntry
        {
            get => _groupServiceEntry;
            set
            {
                GroupServiceEntrySpecified = true;
                _groupServiceEntry = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceEntrySpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AssignedUserServicesEntry> _userServiceEntry = new List<BroadWorksConnector.Ocip.Models.AssignedUserServicesEntry>();

        [XmlElement(ElementName = "userServiceEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:840")]
        public List<BroadWorksConnector.Ocip.Models.AssignedUserServicesEntry> UserServiceEntry
        {
            get => _userServiceEntry;
            set
            {
                UserServiceEntrySpecified = true;
                _userServiceEntry = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceEntrySpecified { get; set; }

    }
}
