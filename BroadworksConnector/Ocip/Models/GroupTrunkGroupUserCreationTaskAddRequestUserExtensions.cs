using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15995""}]")]
    public class GroupTrunkGroupUserCreationTaskAddRequestUserExtensions
    {

        private List<string> _extension = new List<string>();

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15995")]
        [MinLength(2)]
        [MaxLength(6)]
        public List<string> Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ExtensionRange> _extensionRange = new List<BroadWorksConnector.Ocip.Models.ExtensionRange>();

        [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15995")]
        public List<BroadWorksConnector.Ocip.Models.ExtensionRange> ExtensionRange
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
