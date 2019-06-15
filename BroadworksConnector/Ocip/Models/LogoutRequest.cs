using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// LogoutRequest is sent when an OCI user logs out or when connection is lost.
    /// This command can be sent either to the server, or to the client from OCS.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="LogoutRequest"/>
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class LogoutRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.LogoutRequestReason _reason;

        [XmlElement(ElementName = "reason", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LogoutRequestReason Reason {
            get => _reason;
            set {
                ReasonSpecified = true;
                _reason = value;
            }
        }

        [XmlIgnore]
        public bool ReasonSpecified { get; set; }
        
    }
}
