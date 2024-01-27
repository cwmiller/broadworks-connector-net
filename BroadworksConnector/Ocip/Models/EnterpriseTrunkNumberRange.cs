using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Directory number range. The minimum and maximum values are inclusive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3092""}]")]
    public class EnterpriseTrunkNumberRange
    {

        protected BroadWorksConnector.Ocip.Models.DNRange _dnRange;

        [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3092")]
        public BroadWorksConnector.Ocip.Models.DNRange DnRange
        {
            get => _dnRange;
            set
            {
                DnRangeSpecified = true;
                _dnRange = value;
            }
        }

        [XmlIgnore]
        protected bool DnRangeSpecified { get; set; }

        protected int _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3092")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int ExtensionLength
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
