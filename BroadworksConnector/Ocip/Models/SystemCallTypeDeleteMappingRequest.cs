using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a system call type mapping.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallTypeDeleteMappingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _digitMap;

        [XmlElement(ElementName = "digitMap", IsNullable = false, Namespace = "")]
        public string DigitMap {
            get => _digitMap;
            set {
                DigitMapSpecified = true;
                _digitMap = value;
            }
        }

        [XmlIgnore]
        public bool DigitMapSpecified { get; set; }
        
    }
}
