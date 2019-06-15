using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<string> _statusCode;

        [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
        public List<string> StatusCode {
            get => _statusCode;
            set {
                StatusCodeSpecified = true;
                _statusCode = value;
            }
        }

        [XmlIgnore]
        public bool StatusCodeSpecified { get; set; }
        
    }
}
