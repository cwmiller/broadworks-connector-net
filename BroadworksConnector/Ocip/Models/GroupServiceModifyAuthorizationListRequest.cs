using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests to change the group's service authorization status.
    /// The boolean flags are used to authorize or unauthorize services and packs.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7896""}]")]
    public class GroupServiceModifyAuthorizationListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7896")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7896")]
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

        private List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization> _servicePackAuthorization = new List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization>();

        [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7896")]
        public List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization> ServicePackAuthorization
        {
            get => _servicePackAuthorization;
            set
            {
                ServicePackAuthorizationSpecified = true;
                _servicePackAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackAuthorizationSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> _groupServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization>();

        [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7896")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7896")]
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
