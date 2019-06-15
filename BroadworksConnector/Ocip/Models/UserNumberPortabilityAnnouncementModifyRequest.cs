using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Number Portability Announcement attributes for the user.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserNumberPortabilityAnnouncementModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _enable;

        [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
        public bool Enable {
            get => _enable;
            set {
                EnableSpecified = true;
                _enable = value;
            }
        }

        [XmlIgnore]
        public bool EnableSpecified { get; set; }
        
    }
}
