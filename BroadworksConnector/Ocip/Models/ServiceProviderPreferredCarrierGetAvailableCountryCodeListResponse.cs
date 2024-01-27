using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:173""}]")]
    public class ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultCountryCode;

        [XmlElement(ElementName = "defaultCountryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:173")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string DefaultCountryCode
        {
            get => _defaultCountryCode;
            set
            {
                DefaultCountryCodeSpecified = true;
                _defaultCountryCode = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultCountryCodeSpecified { get; set; }

        protected List<string> _countryCode = new List<string>();

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:173")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public List<string> CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

    }
}
