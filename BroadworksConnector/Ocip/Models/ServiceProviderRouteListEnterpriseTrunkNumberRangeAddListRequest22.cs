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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:612""}]")]
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:612")]
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

        private List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkNumberRange> _numberRange = new List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkNumberRange>();

        [XmlElement(ElementName = "numberRange", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:612")]
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
