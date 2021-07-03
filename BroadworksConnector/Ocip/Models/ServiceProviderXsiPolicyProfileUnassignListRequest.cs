using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of Xsi policy profile.
    /// Unassign a list of Xsi policy profile.
    /// Only group and user level Xsi policy profile can be unassigned.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:7158""}]")]
    public class ServiceProviderXsiPolicyProfileUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7158")]
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

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry _groupXsiPolicyProfile;

        [XmlElement(ElementName = "groupXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7158")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry GroupXsiPolicyProfile
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

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry _userXsiPolicyProfile;

        [XmlElement(ElementName = "userXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7158")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileUnassignEntry UserXsiPolicyProfile
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
