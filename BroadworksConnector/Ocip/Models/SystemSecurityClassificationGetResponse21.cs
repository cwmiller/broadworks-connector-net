using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSecurityClassificationGetRequest21.
    /// Contains a table with column headings:
    /// "Name", "Priority".
    /// <see cref="SystemSecurityClassificationGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:257""}]")]
    public class SystemSecurityClassificationGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _meetMeAnncThreshold;

        [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:257")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int MeetMeAnncThreshold
        {
            get => _meetMeAnncThreshold;
            set
            {
                MeetMeAnncThresholdSpecified = true;
                _meetMeAnncThreshold = value;
            }
        }

        [XmlIgnore]
        protected bool MeetMeAnncThresholdSpecified { get; set; }

        private bool _playTrunkUserSecurityClassificationAnnouncement;

        [XmlElement(ElementName = "playTrunkUserSecurityClassificationAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:257")]
        public bool PlayTrunkUserSecurityClassificationAnnouncement
        {
            get => _playTrunkUserSecurityClassificationAnnouncement;
            set
            {
                PlayTrunkUserSecurityClassificationAnnouncementSpecified = true;
                _playTrunkUserSecurityClassificationAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool PlayTrunkUserSecurityClassificationAnnouncementSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationTable;

        [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:257")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SecurityClassificationTable
        {
            get => _securityClassificationTable;
            set
            {
                SecurityClassificationTableSpecified = true;
                _securityClassificationTable = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationTableSpecified { get; set; }

    }
}
