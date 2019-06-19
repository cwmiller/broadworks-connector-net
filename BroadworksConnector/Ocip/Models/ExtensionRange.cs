using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Extension range. The minimum and maximum values are inclusive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43184""}]")]
    public class ExtensionRange
    {

        private string _minExtension;

        [XmlElement(ElementName = "minExtension", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43184")]
        [MinLength(2)]
        [MaxLength(6)]
        public string MinExtension
        {
            get => _minExtension;
            set
            {
                MinExtensionSpecified = true;
                _minExtension = value;
            }
        }

        [XmlIgnore]
        public bool MinExtensionSpecified { get; set; }

        private string _maxExtension;

        [XmlElement(ElementName = "maxExtension", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43184")]
        [MinLength(2)]
        [MaxLength(6)]
        public string MaxExtension
        {
            get => _maxExtension;
            set
            {
                MaxExtensionSpecified = true;
                _maxExtension = value;
            }
        }

        [XmlIgnore]
        public bool MaxExtensionSpecified { get; set; }

    }
}
