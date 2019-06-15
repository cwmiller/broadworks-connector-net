using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest.
    /// The response contains of the list of system level successful SIP OPTIONS message respoonse status codes.
        /// <see cref="SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
