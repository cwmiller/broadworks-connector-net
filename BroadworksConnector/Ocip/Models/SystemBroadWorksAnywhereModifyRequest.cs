using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the BroadWorks Anywhere system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksAnywhereModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enableTransferNotification;

        [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
        public bool EnableTransferNotification {
            get => _enableTransferNotification;
            set {
                EnableTransferNotificationSpecified = true;
                _enableTransferNotification = value;
            }
        }

        [XmlIgnore]
        public bool EnableTransferNotificationSpecified { get; set; }
        
    }
}
