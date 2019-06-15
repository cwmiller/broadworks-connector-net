using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Automatic Collect Call service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAutomaticCollectCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        public bool EnableAutomaticCollectCall {
            get => _enableAutomaticCollectCall;
            set {
                EnableAutomaticCollectCallSpecified = true;
                _enableAutomaticCollectCall = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutomaticCollectCallSpecified { get; set; }
        
        private bool _enableConnectTone;

        [XmlElement(ElementName = "enableConnectTone", IsNullable = false, Namespace = "")]
        public bool EnableConnectTone {
            get => _enableConnectTone;
            set {
                EnableConnectToneSpecified = true;
                _enableConnectTone = value;
            }
        }

        [XmlIgnore]
        public bool EnableConnectToneSpecified { get; set; }
        
    }
}
