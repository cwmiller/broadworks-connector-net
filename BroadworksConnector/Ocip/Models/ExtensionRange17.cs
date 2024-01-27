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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3232""}]")]
    public class ExtensionRange17
    {

        protected string _minExtension;

        [XmlElement(ElementName = "minExtension", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3232")]
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
        protected bool MinExtensionSpecified { get; set; }

        protected string _maxExtension;

        [XmlElement(ElementName = "maxExtension", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3232")]
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
        protected bool MaxExtensionSpecified { get; set; }

    }
}
