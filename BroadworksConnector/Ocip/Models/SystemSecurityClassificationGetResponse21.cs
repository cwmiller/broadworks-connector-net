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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""435c279b3e6710f4ada60ed66a93d278:257""}]")]
    public class SystemSecurityClassificationGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _meetMeAnncThreshold;

        [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:257")]
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

        protected bool _playTrunkUserSecurityClassificationAnnouncement;

        [XmlElement(ElementName = "playTrunkUserSecurityClassificationAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:257")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationTable;

        [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false, Namespace = "")]
        [Group(@"435c279b3e6710f4ada60ed66a93d278:257")]
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
