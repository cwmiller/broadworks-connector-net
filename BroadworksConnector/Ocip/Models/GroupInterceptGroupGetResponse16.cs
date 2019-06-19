using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupInterceptGroupGetRequest16.
    /// Replaced By: GroupInterceptGroupGetResponse16sp1
    /// <see cref="GroupInterceptGroupGetRequest16"/>
    /// <see cref="GroupInterceptGroupGetResponse16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9119""}]")]
    public class GroupInterceptGroupGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection
        {
            get => _announcementSelection;
            set
            {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementSelectionSpecified { get; set; }

        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileDescription
        {
            get => _audioFileDescription;
            set
            {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType
        {
            get => _audioMediaType;
            set
            {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        public bool AudioMediaTypeSpecified { get; set; }

        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileDescription
        {
            get => _videoFileDescription;
            set
            {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType
        {
            get => _videoMediaType;
            set
            {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        public bool VideoMediaTypeSpecified { get; set; }

        private bool _playNewPhoneNumber;

        [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public bool PlayNewPhoneNumber
        {
            get => _playNewPhoneNumber;
            set
            {
                PlayNewPhoneNumberSpecified = true;
                _playNewPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PlayNewPhoneNumberSpecified { get; set; }

        private string _newPhoneNumber;

        [XmlElement(ElementName = "newPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        [MinLength(1)]
        [MaxLength(23)]
        public string NewPhoneNumber
        {
            get => _newPhoneNumber;
            set
            {
                NewPhoneNumberSpecified = true;
                _newPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool NewPhoneNumberSpecified { get; set; }

        private bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        public bool TransferOnZeroToPhoneNumber
        {
            get => _transferOnZeroToPhoneNumber;
            set
            {
                TransferOnZeroToPhoneNumberSpecified = true;
                _transferOnZeroToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9119")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferPhoneNumberSpecified { get; set; }

    }
}
