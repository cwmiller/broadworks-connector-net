using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call to Number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1003""}]")]
    public class CallToNumber
    {

        private BroadWorksConnector.Ocip.Models.CallToNumberType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1003")]
        public BroadWorksConnector.Ocip.Models.CallToNumberType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }

        private string _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1003")]
        [MinLength(1)]
        [MaxLength(23)]
        public string Number
        {
            get => _number;
            set
            {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        public bool NumberSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1003")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }

    }
}
