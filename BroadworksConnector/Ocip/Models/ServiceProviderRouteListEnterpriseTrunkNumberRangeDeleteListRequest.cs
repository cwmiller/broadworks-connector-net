using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete number ranges from a service provider.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:647""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:647")]
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

        protected List<string> _numberRangeStart = new List<string>();

        [XmlElement(ElementName = "numberRangeStart", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:647")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> NumberRangeStart
        {
            get => _numberRangeStart;
            set
            {
                NumberRangeStartSpecified = true;
                _numberRangeStart = value;
            }
        }

        [XmlIgnore]
        protected bool NumberRangeStartSpecified { get; set; }

    }
}
