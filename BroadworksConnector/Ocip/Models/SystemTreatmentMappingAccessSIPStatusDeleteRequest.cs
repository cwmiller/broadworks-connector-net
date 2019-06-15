using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an Access SIP Status Code mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTreatmentMappingAccessSIPStatusDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _sipStatusCode;

        [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
        public int SipStatusCode {
            get => _sipStatusCode;
            set {
                SipStatusCodeSpecified = true;
                _sipStatusCode = value;
            }
        }

        [XmlIgnore]
        public bool SipStatusCodeSpecified { get; set; }
        
    }
}
