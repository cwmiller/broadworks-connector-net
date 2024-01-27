using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
    /// The response is either a ServiceProviderTrunkGroupGetResponse14sp1 or an ErrorResponse.
    /// 
    /// Deprecated by ServiceProviderTrunkGroupGetRequest23
    /// <see cref="ServiceProviderTrunkGroupGetResponse14sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderTrunkGroupGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19845""}]")]
    public class ServiceProviderTrunkGroupGetRequest14sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderTrunkGroupGetResponse14sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19845")]
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
