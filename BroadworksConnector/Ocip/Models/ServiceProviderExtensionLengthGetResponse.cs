using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderExtensionLengthGetRequest.
    /// <see cref="ServiceProviderExtensionLengthGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4156""}]")]
    public class ServiceProviderExtensionLengthGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4156")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int DefaultExtensionLength
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

        private int _locationRoutingPrefixDigit;

        [XmlElement(ElementName = "locationRoutingPrefixDigit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4156")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int LocationRoutingPrefixDigit
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

        private int _locationCodeLength;

        [XmlElement(ElementName = "locationCodeLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4156")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int LocationCodeLength
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
