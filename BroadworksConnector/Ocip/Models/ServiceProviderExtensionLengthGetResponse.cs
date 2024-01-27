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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4235""}]")]
    public class ServiceProviderExtensionLengthGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4235")]
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

        protected int _locationRoutingPrefixDigit;

        [XmlElement(ElementName = "locationRoutingPrefixDigit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4235")]
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

        protected int _locationCodeLength;

        [XmlElement(ElementName = "locationCodeLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4235")]
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
