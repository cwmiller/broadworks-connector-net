using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Pair of DeviceManagementTagSetName
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2396""}]")]
    public class DeviceManagementTagSetRename
    {

        private string _originalTagSetName;

        [XmlElement(ElementName = "originalTagSetName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2396")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OriginalTagSetName
        {
            get => _originalTagSetName;
            set
            {
                OriginalTagSetNameSpecified = true;
                _originalTagSetName = value;
            }
        }

        [XmlIgnore]
        protected bool OriginalTagSetNameSpecified { get; set; }

        private string _newTagSetName;

        [XmlElement(ElementName = "newTagSetName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2396")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewTagSetName
        {
            get => _newTagSetName;
            set
            {
                NewTagSetNameSpecified = true;
                _newTagSetName = value;
            }
        }

        [XmlIgnore]
        protected bool NewTagSetNameSpecified { get; set; }

    }
}
