using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the maximum number of target users per paging group configured for a service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:562""}]")]
    public class ServiceProviderGroupPagingTargetsCapacityModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:562")]
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

        private int _maximumTargetUsers;

        [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d36df8c109e3ea7324f79031368c661:562")]
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
