using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderGroupPagingTargetsCapacityGetRequest.
    /// 
    /// Replaced by: ServiceProviderGroupPagingTargetsCapacityGetResponse22 in AS data mode.
    /// <see cref="ServiceProviderGroupPagingTargetsCapacityGetRequest"/>
    /// <see cref="ServiceProviderGroupPagingTargetsCapacityGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5910""}]")]
    public class ServiceProviderGroupPagingTargetsCapacityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maximumTargetUsers;

        [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5910")]
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
