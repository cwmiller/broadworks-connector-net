using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Directory number range for modification.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2622""}]")]
    public class EnterpriseTrunkNumberRangeModify
    {

        private string _dnRangeStart;

        [XmlElement(ElementName = "dnRangeStart", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2622")]
        [MinLength(1)]
        [MaxLength(23)]
        public string DnRangeStart
        {
            get => _dnRangeStart;
            set
            {
                DnRangeStartSpecified = true;
                _dnRangeStart = value;
            }
        }

        [XmlIgnore]
        protected bool DnRangeStartSpecified { get; set; }

        private int? _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2622")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int? ExtensionLength
        {
            get => _extensionLength;
            set
            {
                ExtensionLengthSpecified = true;
                _extensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionLengthSpecified { get; set; }

    }
}
