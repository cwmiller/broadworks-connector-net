using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the utilization of a single DN.
    /// The response is either SystemDnGetUtilizationResponse or ErrorResponse.
    /// Replaced By: SystemDnGetUtilizationRequest14sp3
        /// <see cref="SystemDnGetUtilizationResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemDnGetUtilizationRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDnGetUtilizationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
    }
}
