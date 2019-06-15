using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Calling Party Category.
    /// The response is either a UserCallingPartyCategoryGetResponse16 or an
    /// ErrorResponse.
        /// <see cref="UserCallingPartyCategoryGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallingPartyCategoryGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
