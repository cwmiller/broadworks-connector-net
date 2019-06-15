using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
    /// The response is either a UserBroadWorksAnywhereGetResponse or an ErrorResponse.
    /// Replaced by: UserBroadWorksAnywhereGetRequest16sp2
        /// <see cref="UserBroadWorksAnywhereGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserBroadWorksAnywhereGetRequest16sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksAnywhereGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
