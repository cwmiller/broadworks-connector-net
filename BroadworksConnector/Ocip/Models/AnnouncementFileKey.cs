using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies a file within a group or user repository.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:601""}]")]
    public class AnnouncementFileKey
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:601")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaFileType;

        [XmlElement(ElementName = "mediaFileType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:601")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaFileType
        {
            get => _mediaFileType;
            set
            {
                MediaFileTypeSpecified = true;
                _mediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool MediaFileTypeSpecified { get; set; }

    }
}
