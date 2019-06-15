using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's sequential ring service setting.
    /// The response is either a UserSequentialRingGetResponse13mp16 or an ErrorResponse.
    /// Replaced By: UserSequentialRingGetRequest14sp4
        /// <see cref="UserSequentialRingGetResponse13mp16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSequentialRingGetRequest14sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSequentialRingGetRequest13mp16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
