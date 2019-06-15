using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the User Personal Assistant information.
    /// The response is either a UserPersonalAssistantGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserPersonalAssistantGetRequest22
        /// <see cref="UserPersonalAssistantGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserPersonalAssistantGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalAssistantGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
