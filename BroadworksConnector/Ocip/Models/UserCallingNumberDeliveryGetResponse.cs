using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallingNumberDeliveryGetRequest.
        /// <see cref="UserCallingNumberDeliveryGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallingNumberDeliveryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActiveForExternalCalls;

        [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
        public bool IsActiveForExternalCalls {
            get => _isActiveForExternalCalls;
            set {
                IsActiveForExternalCallsSpecified = true;
                _isActiveForExternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveForExternalCallsSpecified { get; set; }
        
        private bool _isActiveForInternalCalls;

        [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false, Namespace = "")]
        public bool IsActiveForInternalCalls {
            get => _isActiveForInternalCalls;
            set {
                IsActiveForInternalCallsSpecified = true;
                _isActiveForInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveForInternalCallsSpecified { get; set; }
        
    }
}
