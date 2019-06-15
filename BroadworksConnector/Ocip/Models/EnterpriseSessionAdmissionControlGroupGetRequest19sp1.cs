using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a session admission control group for the enterprise.
    /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse19sp1 or an ErrorResponse.
    /// 
    /// Replaced by: EnterpriseSessionAdmissionControlGroupGetRequest21sp1
        /// <see cref="EnterpriseSessionAdmissionControlGroupGetResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseSessionAdmissionControlGroupGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseSessionAdmissionControlGroupGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
