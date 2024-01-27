using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupServiceGetAuthorizedListRequest.
    /// <see cref="GroupServiceGetAuthorizedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:7581""}]")]
    public class GroupServiceGetAuthorizedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7581")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.GroupService> _groupServiceName = new List<BroadWorksConnector.Ocip.Models.GroupService>();

        [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7581")]
        public List<BroadWorksConnector.Ocip.Models.GroupService> GroupServiceName
        {
            get => _groupServiceName;
            set
            {
                GroupServiceNameSpecified = true;
                _groupServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _userServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7581")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserServiceName
        {
            get => _userServiceName;
            set
            {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceNameSpecified { get; set; }

    }
}
