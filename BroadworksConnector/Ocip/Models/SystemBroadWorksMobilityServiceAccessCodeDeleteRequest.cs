using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a system service access code.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityServiceAccessCodeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public string CountryCode {
            get => _countryCode;
            set {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        
        private string _serviceAccessCode;

        [XmlElement(ElementName = "serviceAccessCode", IsNullable = false, Namespace = "")]
        public string ServiceAccessCode {
            get => _serviceAccessCode;
            set {
                ServiceAccessCodeSpecified = true;
                _serviceAccessCode = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessCodeSpecified { get; set; }
        
    }
}
