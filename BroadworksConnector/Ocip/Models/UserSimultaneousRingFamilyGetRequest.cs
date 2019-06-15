using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's simultaneous ring service family setting.
    /// The response is either a UserSimultaneousRingFamilyGetResponse or an ErrorResponse.
    /// Replaced By: UserSimultaneousRingFamilyGetRequest14sp4
        /// <see cref="UserSimultaneousRingFamilyGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSimultaneousRingFamilyGetRequest14sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSimultaneousRingFamilyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
