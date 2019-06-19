using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetRequest.
    /// Contains the settings that apply to the whole group for Call Park.
    /// <see cref="GroupCallParkGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19123""}]")]
    public class GroupCallParkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _recallTimerSeconds;

        [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19123")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int RecallTimerSeconds
        {
            get => _recallTimerSeconds;
            set
            {
                RecallTimerSecondsSpecified = true;
                _recallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RecallTimerSecondsSpecified { get; set; }

        private int _displayTimerSeconds;

        [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19123")]
        [MinInclusive(2)]
        [MaxInclusive(15)]
        public int DisplayTimerSeconds
        {
            get => _displayTimerSeconds;
            set
            {
                DisplayTimerSecondsSpecified = true;
                _displayTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DisplayTimerSecondsSpecified { get; set; }

        private bool _enableDestinationAnnouncement;

        [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19123")]
        public bool EnableDestinationAnnouncement
        {
            get => _enableDestinationAnnouncement;
            set
            {
                EnableDestinationAnnouncementSpecified = true;
                _enableDestinationAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool EnableDestinationAnnouncementSpecified { get; set; }

    }
}
