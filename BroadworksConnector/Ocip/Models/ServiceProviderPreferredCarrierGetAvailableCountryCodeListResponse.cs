using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest.
    /// Contains the default country code and the list of unused country codes for a service provider / enterprise.
        /// <see cref="ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _defaultCountryCode;

        [XmlElement(ElementName = "defaultCountryCode", IsNullable = false, Namespace = "")]
        public string DefaultCountryCode {
            get => _defaultCountryCode;
            set {
                DefaultCountryCodeSpecified = true;
                _defaultCountryCode = value;
            }
        }

        [XmlIgnore]
        public bool DefaultCountryCodeSpecified { get; set; }
        
        private List<string> _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public List<string> CountryCode {
            get => _countryCode;
            set {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        
    }
}
