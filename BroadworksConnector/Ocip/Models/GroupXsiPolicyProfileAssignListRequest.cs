using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a group level Xsi policy profile and a list of user Xsi policy profiles
    /// to a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8912""}]")]
    public class GroupXsiPolicyProfileAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8912")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8912")]
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

        private string _groupXsiPolicyProfile;

        [XmlElement(ElementName = "groupXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8912")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupXsiPolicyProfile
        {
            get => _groupXsiPolicyProfile;
            set
            {
                GroupXsiPolicyProfileSpecified = true;
                _groupXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool GroupXsiPolicyProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileAssignEntry _userXsiPolicyProfile;

        [XmlElement(ElementName = "userXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8912")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileAssignEntry UserXsiPolicyProfile
        {
            get => _userXsiPolicyProfile;
            set
            {
                UserXsiPolicyProfileSpecified = true;
                _userXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UserXsiPolicyProfileSpecified { get; set; }

    }
}
