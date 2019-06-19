using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointOverflowGetRequest20.
    /// <see cref="GroupRoutePointOverflowGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:1031""}]")]
    public class GroupRoutePointOverflowGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterOverflowProcessingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.CallCenterOverflowProcessingAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        [MinLength(1)]
        [MaxLength(161)]
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

        private bool _overflowAfterTimeout;

        [XmlElement(ElementName = "overflowAfterTimeout", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public bool OverflowAfterTimeout
        {
            get => _overflowAfterTimeout;
            set
            {
                OverflowAfterTimeoutSpecified = true;
                _overflowAfterTimeout = value;
            }
        }

        [XmlIgnore]
        public bool OverflowAfterTimeoutSpecified { get; set; }

        private int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int TimeoutSeconds
        {
            get => _timeoutSeconds;
            set
            {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutSecondsSpecified { get; set; }

        private bool _playAnnouncementBeforeOverflowProcessing;

        [XmlElement(ElementName = "playAnnouncementBeforeOverflowProcessing", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public bool PlayAnnouncementBeforeOverflowProcessing
        {
            get => _playAnnouncementBeforeOverflowProcessing;
            set
            {
                PlayAnnouncementBeforeOverflowProcessingSpecified = true;
                _playAnnouncementBeforeOverflowProcessing = value;
            }
        }

        [XmlIgnore]
        public bool PlayAnnouncementBeforeOverflowProcessingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool AudioUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool VideoUrlListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1031")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileListSpecified { get; set; }

    }
}
