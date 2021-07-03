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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1494""}]")]
    public class GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions
    {

        private List<string> _extension = new List<string>();

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1494")]
        [MinLength(2)]
        [MaxLength(20)]
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

        private List<BroadWorksConnector.Ocip.Models.ExtensionRange17> _extensionRange = new List<BroadWorksConnector.Ocip.Models.ExtensionRange17>();

        [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1494")]
        public List<BroadWorksConnector.Ocip.Models.ExtensionRange17> ExtensionRange
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
