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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3104""}]")]
    public class EnterpriseTrunkNumberRangeModify
    {

        protected string _dnRangeStart;

        [XmlElement(ElementName = "dnRangeStart", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3104")]
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

        protected int? _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3104")]
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
