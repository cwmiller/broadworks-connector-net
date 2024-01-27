using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEventRecordingFileParametersGetRequest.
    /// Contains a list of system Call Center Event Recording File parameters.
    /// <see cref="SystemCallCenterEventRecordingFileParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6482""}]")]
    public class SystemCallCenterEventRecordingFileParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _fileRetentionTimeDays;

        [XmlElement(ElementName = "fileRetentionTimeDays", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6482")]
        [MinInclusive(0)]
        [MaxInclusive(120)]
        public int FileRetentionTimeDays
        {
            get => _fileRetentionTimeDays;
            set
            {
                FileRetentionTimeDaysSpecified = true;
                _fileRetentionTimeDays = value;
            }
        }

        [XmlIgnore]
        protected bool FileRetentionTimeDaysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterEventRecordingFileRotationPeriodMinutes _fileRotationPeriodMinutes;

        [XmlElement(ElementName = "fileRotationPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6482")]
        public BroadWorksConnector.Ocip.Models.CallCenterEventRecordingFileRotationPeriodMinutes FileRotationPeriodMinutes
        {
            get => _fileRotationPeriodMinutes;
            set
            {
                FileRotationPeriodMinutesSpecified = true;
                _fileRotationPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool FileRotationPeriodMinutesSpecified { get; set; }

        protected int _fileRotationOffsetMinutes;

        [XmlElement(ElementName = "fileRotationOffsetMinutes", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6482")]
        [MinInclusive(0)]
        [MaxInclusive(59)]
        public int FileRotationOffsetMinutes
        {
            get => _fileRotationOffsetMinutes;
            set
            {
                FileRotationOffsetMinutesSpecified = true;
                _fileRotationOffsetMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool FileRotationOffsetMinutesSpecified { get; set; }

        protected string _remoteUrl;

        [XmlElement(ElementName = "remoteUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6482")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RemoteUrl
        {
            get => _remoteUrl;
            set
            {
                RemoteUrlSpecified = true;
                _remoteUrl = value;
            }
        }

        [XmlIgnore]
        protected bool RemoteUrlSpecified { get; set; }

        protected string _remoteUserId;

        [XmlElement(ElementName = "remoteUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6482")]
        [MinLength(1)]
        [MaxLength(20)]
        public string RemoteUserId
        {
            get => _remoteUserId;
            set
            {
                RemoteUserIdSpecified = true;
                _remoteUserId = value;
            }
        }

        [XmlIgnore]
        protected bool RemoteUserIdSpecified { get; set; }

    }
}
