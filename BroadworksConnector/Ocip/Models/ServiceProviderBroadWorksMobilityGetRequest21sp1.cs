using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider BroadWorks Mobility service settings.
    /// The response is either a ServiceProviderBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
    /// 
    /// Replaced by ServiceProviderBroadWorksMobilityGetRequest22V2.
    /// <see cref="ServiceProviderBroadWorksMobilityGetResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderBroadWorksMobilityGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17329""}]")]
    public class ServiceProviderBroadWorksMobilityGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderBroadWorksMobilityGetResponse21sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17329")]
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
