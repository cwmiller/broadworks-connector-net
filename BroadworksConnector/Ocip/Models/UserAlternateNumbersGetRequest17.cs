using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Alternate Numbers.
    /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
        /// <see cref="UserAlternateNumbersGetResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserAlternateNumbersGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAlternateNumbersGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
