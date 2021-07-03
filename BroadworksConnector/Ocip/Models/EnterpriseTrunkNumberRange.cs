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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2610""}]")]
    public class EnterpriseTrunkNumberRange
    {

        private BroadWorksConnector.Ocip.Models.DNRange _dnRange;

        [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2610")]
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

        private int _extensionLength;

        [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2610")]
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
