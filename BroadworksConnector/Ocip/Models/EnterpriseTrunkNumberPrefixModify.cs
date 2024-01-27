using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Trunk Number Prefix for modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3080""}]")]
    public class EnterpriseTrunkNumberPrefixModify
    {

        protected string _numberPrefix;

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3080")]
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

        protected BroadWorksConnector.Ocip.Models.ExtensionRange17 _extensionRange;

        [XmlElement(ElementName = "extensionRange", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3080")]
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
