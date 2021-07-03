using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a tag name with its associated value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2384""}]")]
    public class DeviceManagementTag
    {

        private string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2384")]
        [MinLength(1)]
        [MaxLength(64)]
        public string TagName
        {
            get => _tagName;
            set
            {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        protected bool TagNameSpecified { get; set; }

        private string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2384")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValue
        {
            get => _tagValue;
            set
            {
                TagValueSpecified = true;
                _tagValue = value;
            }
        }

        [XmlIgnore]
        protected bool TagValueSpecified { get; set; }

    }
}
