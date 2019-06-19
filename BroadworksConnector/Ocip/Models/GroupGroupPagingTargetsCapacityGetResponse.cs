using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupGroupPagingTargetsCapacityGetRequest.
    /// <see cref="GroupGroupPagingTargetsCapacityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:483""}]")]
    public class GroupGroupPagingTargetsCapacityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maximumTargetUsersFromServiceProvider;

        [XmlElement(ElementName = "maximumTargetUsersFromServiceProvider", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:483")]
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
        public bool MaximumTargetUsersFromServiceProviderSpecified { get; set; }

        private int _maximumTargetUsers;

        [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:483")]
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
        public bool MaximumTargetUsersSpecified { get; set; }

    }
}
