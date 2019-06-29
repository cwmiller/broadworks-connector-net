using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests to change the service provider's service authorization status.
    /// The boolean flags are used to authorize or unauthorize services.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5203""}]")]
    public class ServiceProviderServiceModifyAuthorizationListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5203")]
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

        private List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> _groupServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization>();

        [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5203")]
        public List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> GroupServiceAuthorization
        {
            get => _groupServiceAuthorization;
            set
            {
                GroupServiceAuthorizationSpecified = true;
                _groupServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceAuthorizationSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> _userServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization>();

        [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5203")]
        public List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> UserServiceAuthorization
        {
            get => _userServiceAuthorization;
            set
            {
                UserServiceAuthorizationSpecified = true;
                _userServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceAuthorizationSpecified { get; set; }

    }
}
