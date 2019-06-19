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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2324""}]")]
    public class ExtensionRange17
    {

        private string _minExtension;

        [XmlElement(ElementName = "minExtension", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2324")]
        [MinLength(2)]
        [MaxLength(20)]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2324")]
        [MinLength(2)]
        [MaxLength(20)]
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
