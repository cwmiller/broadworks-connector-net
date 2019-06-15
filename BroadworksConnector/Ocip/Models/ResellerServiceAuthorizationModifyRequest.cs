using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller service authorization file.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerServiceAuthorizationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.FileResource _serviceOffering;

        [XmlElement(ElementName = "serviceOffering", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileResource ServiceOffering {
            get => _serviceOffering;
            set {
                ServiceOfferingSpecified = true;
                _serviceOffering = value;
            }
        }

        [XmlIgnore]
        public bool ServiceOfferingSpecified { get; set; }
        
    }
}
