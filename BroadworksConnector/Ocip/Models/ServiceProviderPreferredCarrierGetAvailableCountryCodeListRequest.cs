using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the default country code and the list of unused country codes for a service provider / enterprise.
    /// The response is either a ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse or an ErrorResponse.
    /// <see cref="ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:157""}]")]
    public class ServiceProviderPreferredCarrierGetAvailableCountryCodeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:157")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

    }
}
