using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deactivate number prefixes in a service provider.
    /// It is not an error to deactivate an already deactivated number prefix.
    /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:476""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:476")]
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

        protected List<string> _numberPrefix = new List<string>();

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:476")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> NumberPrefix
        {
            get => _numberPrefix;
            set
            {
                NumberPrefixSpecified = true;
                _numberPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPrefixSpecified { get; set; }

    }
}
