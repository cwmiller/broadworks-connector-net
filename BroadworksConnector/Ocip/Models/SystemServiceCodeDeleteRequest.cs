using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a service code for the purpose of providing free format routable strings for dialing
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServiceCodeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceCode;

        [XmlElement(ElementName = "serviceCode", IsNullable = false, Namespace = "")]
        public string ServiceCode {
            get => _serviceCode;
            set {
                ServiceCodeSpecified = true;
                _serviceCode = value;
            }
        }

        [XmlIgnore]
        public bool ServiceCodeSpecified { get; set; }
        
    }
}
