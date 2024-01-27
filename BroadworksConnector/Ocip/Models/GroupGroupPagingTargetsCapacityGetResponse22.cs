using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGroupPagingTargetsCapacityGetRequest22.
    /// <see cref="GroupGroupPagingTargetsCapacityGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:494""}]")]
    public class GroupGroupPagingTargetsCapacityGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maximumTargetUsersFromServiceProvider;

        [XmlElement(ElementName = "maximumTargetUsersFromServiceProvider", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:494")]
        [MinInclusive(1)]
        [MaxInclusive(294)]
        public int MaximumTargetUsersFromServiceProvider
        {
            get => _maximumTargetUsersFromServiceProvider;
            set
            {
                MaximumTargetUsersFromServiceProviderSpecified = true;
                _maximumTargetUsersFromServiceProvider = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumTargetUsersFromServiceProviderSpecified { get; set; }

        protected int _maximumTargetUsers;

        [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:494")]
        [MinInclusive(1)]
        [MaxInclusive(294)]
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
