using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This command allows a BroadWorks or Third-Party Client Application to
    /// create a Single Sign-On token for a user.
    /// The response is either ExternalAuthenticationCreateLoginTokenResponse
    /// or ErrorResponse.
        /// <see cref="ExternalAuthenticationCreateLoginTokenResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ExternalAuthenticationCreateLoginTokenRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
