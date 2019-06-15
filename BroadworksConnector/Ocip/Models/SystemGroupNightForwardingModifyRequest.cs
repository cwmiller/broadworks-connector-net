using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Group Night Forwarding system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGroupNightForwardingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _nightForwardGroupCallsWithinEnterprise;

        [XmlElement(ElementName = "nightForwardGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
        public bool NightForwardGroupCallsWithinEnterprise {
            get => _nightForwardGroupCallsWithinEnterprise;
            set {
                NightForwardGroupCallsWithinEnterpriseSpecified = true;
                _nightForwardGroupCallsWithinEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool NightForwardGroupCallsWithinEnterpriseSpecified { get; set; }
        
    }
}
