using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the reseller level data associated with Emergency Call
    /// Notification.
    /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// <see cref="ResellerEmergencyCallNotificationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerEmergencyCallNotificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
