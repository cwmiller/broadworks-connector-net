using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify security classification parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// NOTE: The security classifications must be specified in order of priority. The command fails if all the security classifications defined for the system are not provided.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:294""}]")]
    public class SystemSecurityClassificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _meetMeAnncThreshold;

        [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:294")]
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
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:294")]
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

        private List<string> _securityClassificationName = new List<string>();

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:294")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> SecurityClassificationName
        {
            get => _securityClassificationName;
            set
            {
                SecurityClassificationNameSpecified = true;
                _securityClassificationName = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityClassificationNameSpecified { get; set; }

    }
}
