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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1493""}]")]
    public class GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions
    {

        protected List<string> _extension = new List<string>();

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1493")]
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

        protected List<BroadWorksConnector.Ocip.Models.ExtensionRange17> _extensionRange = new List<BroadWorksConnector.Ocip.Models.ExtensionRange17>();

        [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1493")]
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
