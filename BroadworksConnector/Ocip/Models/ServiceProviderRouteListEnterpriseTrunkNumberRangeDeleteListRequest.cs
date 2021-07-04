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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:648""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:648")]
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

        private List<string> _numberRangeStart = new List<string>();

        [XmlElement(ElementName = "numberRangeStart", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:648")]
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
