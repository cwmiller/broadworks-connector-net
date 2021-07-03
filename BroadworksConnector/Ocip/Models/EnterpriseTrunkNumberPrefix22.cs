using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Trunk Number Prefix
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2586""}]")]
    public class EnterpriseTrunkNumberPrefix22
    {

        private string _numberPrefix;

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2586")]
        [MinLength(1)]
        [MaxLength(23)]
        public string NumberPrefix
        {
            get => _numberPrefix;
            set
            {
                NumberPrefixSpecified = true;
                _numberPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPrefixSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtensionRange17 _extensionRange;

        [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2586")]
        public BroadWorksConnector.Ocip.Models.ExtensionRange17 ExtensionRange
        {
            get => _extensionRange;
            set
            {
                ExtensionRangeSpecified = true;
                _extensionRange = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionRangeSpecified { get; set; }

    }
}
