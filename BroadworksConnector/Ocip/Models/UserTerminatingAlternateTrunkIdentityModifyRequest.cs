using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Terminating Alternate Trunk Identity.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserTerminatingAlternateTrunkIdentityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _terminatingTrunkIdentity;

        [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = true, Namespace = "")]
        public string TerminatingTrunkIdentity {
            get => _terminatingTrunkIdentity;
            set {
                TerminatingTrunkIdentitySpecified = true;
                _terminatingTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool TerminatingTrunkIdentitySpecified { get; set; }
        
    }
}
