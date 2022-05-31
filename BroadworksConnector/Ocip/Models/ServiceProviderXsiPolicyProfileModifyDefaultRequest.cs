using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the default Xsi policy profile for a service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:7174""}]")]
    public class ServiceProviderXsiPolicyProfileModifyDefaultRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7174")]
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

        protected string _groupDefaultXsiPolicyProfile;

        [XmlElement(ElementName = "groupDefaultXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7174")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupDefaultXsiPolicyProfile
        {
            get => _groupDefaultXsiPolicyProfile;
            set
            {
                GroupDefaultXsiPolicyProfileSpecified = true;
                _groupDefaultXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDefaultXsiPolicyProfileSpecified { get; set; }

        protected string _userDefaultXsiPolicyProfile;

        [XmlElement(ElementName = "userDefaultXsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7174")]
        [MinLength(1)]
        [MaxLength(40)]
        public string UserDefaultXsiPolicyProfile
        {
            get => _userDefaultXsiPolicyProfile;
            set
            {
                UserDefaultXsiPolicyProfileSpecified = true;
                _userDefaultXsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UserDefaultXsiPolicyProfileSpecified { get; set; }

    }
}
