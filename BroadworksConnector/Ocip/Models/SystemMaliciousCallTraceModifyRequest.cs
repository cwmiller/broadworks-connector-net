using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Malicious Call Trace system parameter.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        public bool PlayMCTWarningAnnouncement {
            get => _playMCTWarningAnnouncement;
            set {
                PlayMCTWarningAnnouncementSpecified = true;
                _playMCTWarningAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool PlayMCTWarningAnnouncementSpecified { get; set; }
        
    }
}
