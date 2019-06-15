using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a list of events from a user schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserScheduleDeleteEventListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey {
            get => _scheduleKey;
            set {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleKeySpecified { get; set; }
        
        private List<string> _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        public List<string> EventName {
            get => _eventName;
            set {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        public bool EventNameSpecified { get; set; }
        
    }
}
