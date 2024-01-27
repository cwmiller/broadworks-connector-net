using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add number ranges to a service provider.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:611""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:611")]
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

        protected List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkNumberRange> _numberRange = new List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkNumberRange>();

        [XmlElement(ElementName = "numberRange", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:611")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkNumberRange> NumberRange
        {
            get => _numberRange;
            set
            {
                NumberRangeSpecified = true;
                _numberRange = value;
            }
        }

        [XmlIgnore]
        protected bool NumberRangeSpecified { get; set; }

    }
}
