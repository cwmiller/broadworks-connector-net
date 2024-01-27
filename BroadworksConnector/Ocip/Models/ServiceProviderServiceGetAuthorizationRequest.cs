using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's service authorization information for a specific service or service pack.
    /// The response is either ServiceProviderServiceGetAuthorizationResponse or ErrorResponse.
    /// 
    /// The following element is used in AS mode and triggers an ErrorResponse in XS data mode:
    /// servicePackName
    /// <see cref="ServiceProviderServiceGetAuthorizationResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6026"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6028""}]}]")]
    public class ServiceProviderServiceGetAuthorizationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderServiceGetAuthorizationResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6026")]
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

        protected BroadWorksConnector.Ocip.Models.UserService _userServiceName;

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6028")]
        public BroadWorksConnector.Ocip.Models.UserService UserServiceName
        {
            get => _userServiceName;
            set
            {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupService _groupServiceName;

        [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6028")]
        public BroadWorksConnector.Ocip.Models.GroupService GroupServiceName
        {
            get => _groupServiceName;
            set
            {
                GroupServiceNameSpecified = true;
                _groupServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceNameSpecified { get; set; }

        protected string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6028")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

    }
}
