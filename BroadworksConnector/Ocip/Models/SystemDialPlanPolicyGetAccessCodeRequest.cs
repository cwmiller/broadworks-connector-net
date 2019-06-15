using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request access code data associated with system level Dial Plan Policy access codes.
    /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// <see cref="SystemDialPlanPolicyGetAccessCodeResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialPlanPolicyGetAccessCodeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
        public string AccessCode {
            get => _accessCode;
            set {
                AccessCodeSpecified = true;
                _accessCode = value;
            }
        }

        [XmlIgnore]
        public bool AccessCodeSpecified { get; set; }
        
    }
}
