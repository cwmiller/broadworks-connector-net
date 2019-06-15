using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the expensive call notification service parameters.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExpensiveCallNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enablePostAnnouncementDelayTimer;

        [XmlElement(ElementName = "enablePostAnnouncementDelayTimer", IsNullable = false, Namespace = "")]
        public bool EnablePostAnnouncementDelayTimer {
            get => _enablePostAnnouncementDelayTimer;
            set {
                EnablePostAnnouncementDelayTimerSpecified = true;
                _enablePostAnnouncementDelayTimer = value;
            }
        }

        [XmlIgnore]
        public bool EnablePostAnnouncementDelayTimerSpecified { get; set; }
        
        private int _postAnnouncementDelaySeconds;

        [XmlElement(ElementName = "postAnnouncementDelaySeconds", IsNullable = false, Namespace = "")]
        public int PostAnnouncementDelaySeconds {
            get => _postAnnouncementDelaySeconds;
            set {
                PostAnnouncementDelaySecondsSpecified = true;
                _postAnnouncementDelaySeconds = value;
            }
        }

        [XmlIgnore]
        public bool PostAnnouncementDelaySecondsSpecified { get; set; }
        
    }
}
