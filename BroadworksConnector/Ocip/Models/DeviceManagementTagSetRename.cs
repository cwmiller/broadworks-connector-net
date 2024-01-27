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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2863""}]")]
    public class DeviceManagementTagSetRename
    {

        protected string _originalTagSetName;

        [XmlElement(ElementName = "originalTagSetName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2863")]
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

        protected string _newTagSetName;

        [XmlElement(ElementName = "newTagSetName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2863")]
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
