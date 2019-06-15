using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Communication Barring Call Type.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringCallTypeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        public string CallType {
            get => _callType;
            set {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }
        
    }
}
