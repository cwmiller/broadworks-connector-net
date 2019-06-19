using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to assign the user services and service packs to all existing users within the group.
    /// BroadSoft recommends using this command only for small groups with less than 100 users.  This
    /// command will return an error if the group has over 500 users.  The recommended way to bulk
    /// assign/unassign services is Service Pack Migration.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4798""}]")]
    public class GroupExistingUsersAssignUserServiceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4798")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4798")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.UserService> _serviceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4798")]
        public List<BroadWorksConnector.Ocip.Models.UserService> ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }

        private List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4798")]
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
        public bool ServicePackNameSpecified { get; set; }

    }
}
