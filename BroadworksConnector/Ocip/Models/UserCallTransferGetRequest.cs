using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Call Transfer.
    /// The response is either a UserCallTransferGetResponse or an ErrorResponse.
    /// Replaced By: UserCallTransferGetRequest14Sp4
        /// <see cref="UserCallTransferGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserCallTransferGetRequest14Sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallTransferGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
