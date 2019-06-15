using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete one or more entries from a user's personal phone list.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalPhoneListDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _entryName;

        [XmlElement(ElementName = "entryName", IsNullable = false, Namespace = "")]
        public List<string> EntryName {
            get => _entryName;
            set {
                EntryNameSpecified = true;
                _entryName = value;
            }
        }

        [XmlIgnore]
        public bool EntryNameSpecified { get; set; }
        
    }
}
