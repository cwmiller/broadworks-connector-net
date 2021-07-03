using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider's extension length range.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4174""}]")]
    public class ServiceProviderExtensionLengthModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4174")]
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

        private int? _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4174")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int? DefaultExtensionLength
        {
            get => _defaultExtensionLength;
            set
            {
                DefaultExtensionLengthSpecified = true;
                _defaultExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExtensionLengthSpecified { get; set; }

        private int? _locationRoutingPrefixDigit;

        [XmlElement(ElementName = "locationRoutingPrefixDigit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4174")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int? LocationRoutingPrefixDigit
        {
            get => _locationRoutingPrefixDigit;
            set
            {
                LocationRoutingPrefixDigitSpecified = true;
                _locationRoutingPrefixDigit = value;
            }
        }

        [XmlIgnore]
        protected bool LocationRoutingPrefixDigitSpecified { get; set; }

        private int? _locationCodeLength;

        [XmlElement(ElementName = "locationCodeLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4174")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int? LocationCodeLength
        {
            get => _locationCodeLength;
            set
            {
                LocationCodeLengthSpecified = true;
                _locationCodeLength = value;
            }
        }

        [XmlIgnore]
        protected bool LocationCodeLengthSpecified { get; set; }

    }
}
