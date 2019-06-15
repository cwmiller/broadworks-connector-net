using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's pre-alerting service setting.
    /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
        /// <see cref="UserPreAlertingAnnouncementGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserPreAlertingAnnouncementGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPreAlertingAnnouncementGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
