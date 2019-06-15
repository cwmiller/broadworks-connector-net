using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of schedules viewable by a User. The list can be filtered by schedule type.
    /// The response is either a UserScheduleGetEventDetailListResponse or an ErrorResponse.
        /// <see cref="UserScheduleGetEventDetailListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserScheduleGetEventDetailListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _scheduleGlobalKey;

        [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleGlobalKey ScheduleGlobalKey {
            get => _scheduleGlobalKey;
            set {
                ScheduleGlobalKeySpecified = true;
                _scheduleGlobalKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleGlobalKeySpecified { get; set; }
        
    }
}
