using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Call Center Event Recording File system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6502""}]")]
    public class SystemCallCenterEventRecordingFileParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _fileRetentionTimeDays;

        [XmlElement(ElementName = "fileRetentionTimeDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
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
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
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
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
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

        [XmlElement(ElementName = "remoteUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
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

        [XmlElement(ElementName = "remoteUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
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

        protected string _remotePassword;

        [XmlElement(ElementName = "remotePassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6502")]
        [MinLength(1)]
        [MaxLength(20)]
        public string RemotePassword
        {
            get => _remotePassword;
            set
            {
                RemotePasswordSpecified = true;
                _remotePassword = value;
            }
        }

        [XmlIgnore]
        protected bool RemotePasswordSpecified { get; set; }

    }
}
