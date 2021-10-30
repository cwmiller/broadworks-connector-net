using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the maximum number of target users per paging group configured for a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupGroupPagingTargetsCapacityModifyRequest22 in AS data mode.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupGroupPagingTargetsCapacityModifyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:2677""}]")]
    public class GroupGroupPagingTargetsCapacityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2677")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2677")]
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
        protected bool GroupIdSpecified { get; set; }

        private int _maximumTargetUsers;

        [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2677")]
        [MinInclusive(1)]
        [MaxInclusive(149)]
        public int MaximumTargetUsers
        {
            get => _maximumTargetUsers;
            set
            {
                MaximumTargetUsersSpecified = true;
                _maximumTargetUsers = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumTargetUsersSpecified { get; set; }

    }
}
