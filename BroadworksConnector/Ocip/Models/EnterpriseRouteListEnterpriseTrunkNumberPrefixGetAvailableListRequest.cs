using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
    /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
    /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:70""}]")]
    public class EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:70")]
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

    }
}
