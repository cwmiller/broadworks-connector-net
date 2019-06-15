using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's simultaneous ring service personal setting.
    /// The response is either a UserSimultaneousRingPersonalGetResponse or an ErrorResponse.
    /// Replaced By: UserSimultaneousRingPersonalGetRequest14sp4
        /// <see cref="UserSimultaneousRingPersonalGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSimultaneousRingPersonalGetRequest14sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSimultaneousRingPersonalGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
