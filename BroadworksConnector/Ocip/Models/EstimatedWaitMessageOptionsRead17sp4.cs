using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Estimated Wait Message Options
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3135""}]")]
    public class EstimatedWaitMessageOptionsRead17sp4
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode _operatingMode;

        [XmlElement(ElementName = "operatingMode", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        public BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOperatingMode OperatingMode
        {
            get => _operatingMode;
            set
            {
                OperatingModeSpecified = true;
                _operatingMode = value;
            }
        }

        [XmlIgnore]
        protected bool OperatingModeSpecified { get; set; }

        protected bool _playPositionHighVolume;

        [XmlElement(ElementName = "playPositionHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        public bool PlayPositionHighVolume
        {
            get => _playPositionHighVolume;
            set
            {
                PlayPositionHighVolumeSpecified = true;
                _playPositionHighVolume = value;
            }
        }

        [XmlIgnore]
        protected bool PlayPositionHighVolumeSpecified { get; set; }

        protected bool _playTimeHighVolume;

        [XmlElement(ElementName = "playTimeHighVolume", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        public bool PlayTimeHighVolume
        {
            get => _playTimeHighVolume;
            set
            {
                PlayTimeHighVolumeSpecified = true;
                _playTimeHighVolume = value;
            }
        }

        [XmlIgnore]
        protected bool PlayTimeHighVolumeSpecified { get; set; }

        protected int _maximumPositions;

        [XmlElement(ElementName = "maximumPositions", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaximumPositions
        {
            get => _maximumPositions;
            set
            {
                MaximumPositionsSpecified = true;
                _maximumPositions = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumPositionsSpecified { get; set; }

        protected int _maximumWaitingMinutes;

        [XmlElement(ElementName = "maximumWaitingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaximumWaitingMinutes
        {
            get => _maximumWaitingMinutes;
            set
            {
                MaximumWaitingMinutesSpecified = true;
                _maximumWaitingMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumWaitingMinutesSpecified { get; set; }

        protected int _defaultCallHandlingMinutes;

        [XmlElement(ElementName = "defaultCallHandlingMinutes", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int DefaultCallHandlingMinutes
        {
            get => _defaultCallHandlingMinutes;
            set
            {
                DefaultCallHandlingMinutesSpecified = true;
                _defaultCallHandlingMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultCallHandlingMinutesSpecified { get; set; }

        protected bool _playUpdatedEWM;

        [XmlElement(ElementName = "playUpdatedEWM", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        public bool PlayUpdatedEWM
        {
            get => _playUpdatedEWM;
            set
            {
                PlayUpdatedEWMSpecified = true;
                _playUpdatedEWM = value;
            }
        }

        [XmlIgnore]
        protected bool PlayUpdatedEWMSpecified { get; set; }

        protected int _timeBetweenEWMUpdatesSeconds;

        [XmlElement(ElementName = "timeBetweenEWMUpdatesSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3135")]
        [MinInclusive(10)]
        [MaxInclusive(600)]
        public int TimeBetweenEWMUpdatesSeconds
        {
            get => _timeBetweenEWMUpdatesSeconds;
            set
            {
                TimeBetweenEWMUpdatesSecondsSpecified = true;
                _timeBetweenEWMUpdatesSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeBetweenEWMUpdatesSecondsSpecified { get; set; }

    }
}
