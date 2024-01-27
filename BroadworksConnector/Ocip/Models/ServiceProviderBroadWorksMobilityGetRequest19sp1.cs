using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider BroadWorks Mobility service settings.
    /// The response is either a ServiceProviderBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderBroadWorksMobilityGetRequest22 in AS data mode
    /// <see cref="ServiceProviderBroadWorksMobilityGetResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderBroadWorksMobilityGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:17835""}]")]
    public class ServiceProviderBroadWorksMobilityGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderBroadWorksMobilityGetResponse19sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17835")]
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
