using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of Network Classes of Service from a service provider.
    /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
    /// Network Classes of Service assigned to the service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5147""}]")]
    public class ServiceProviderNetworkClassOfServiceUnassignListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5147")]
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

        protected List<string> _networkClassOfService = new List<string>();

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5147")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DefaultNetworkClassOfService _defaultNetworkClassOfService;

        [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5147")]
        public BroadWorksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService
        {
            get => _defaultNetworkClassOfService;
            set
            {
                DefaultNetworkClassOfServiceSpecified = true;
                _defaultNetworkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultNetworkClassOfServiceSpecified { get; set; }

    }
}
