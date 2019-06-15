using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the active status of Find-me/Follow-me instances.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFindMeFollowMeModifyActiveInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.ServiceActivation> _serviceActivation;

        [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ServiceActivation> ServiceActivation {
            get => _serviceActivation;
            set {
                ServiceActivationSpecified = true;
                _serviceActivation = value;
            }
        }

        [XmlIgnore]
        public bool ServiceActivationSpecified { get; set; }
        
    }
}
