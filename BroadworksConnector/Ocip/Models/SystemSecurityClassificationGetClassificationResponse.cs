using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSecurityClassificationGetClassificationRequest.
    /// <see cref="SystemSecurityClassificationGetClassificationRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:150""}]")]
    public class SystemSecurityClassificationGetClassificationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _audioAnnouncementFileDescription;

        [XmlElement(ElementName = "audioAnnouncementFileDescription", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:150")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioAnnouncementFileDescription
        {
            get => _audioAnnouncementFileDescription;
            set
            {
                AudioAnnouncementFileDescriptionSpecified = true;
                _audioAnnouncementFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool AudioAnnouncementFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _audioAnnouncementFileType;

        [XmlElement(ElementName = "audioAnnouncementFileType", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:150")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioAnnouncementFileType
        {
            get => _audioAnnouncementFileType;
            set
            {
                AudioAnnouncementFileTypeSpecified = true;
                _audioAnnouncementFileType = value;
            }
        }

        [XmlIgnore]
        protected bool AudioAnnouncementFileTypeSpecified { get; set; }

    }
}
