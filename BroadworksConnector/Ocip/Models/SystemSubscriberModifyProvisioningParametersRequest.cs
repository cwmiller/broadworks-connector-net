using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system provisioning configuration for all subscribers.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberModifyProvisioningParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        public bool ConfigurableCLIDNormalization {
            get => _configurableCLIDNormalization;
            set {
                ConfigurableCLIDNormalizationSpecified = true;
                _configurableCLIDNormalization = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurableCLIDNormalizationSpecified { get; set; }
        
    }
}
