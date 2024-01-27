using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's password rules setting applicable to
    /// Administrators (Group and Department) and Users.
    /// The response is either ServiceProviderPasswordRulesGetResponse13mp2 or ErrorResponse.
    /// Replaced By: ServiceProviderPasswordRulesGetRequest16
    /// <see cref="ServiceProviderPasswordRulesGetResponse13mp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderPasswordRulesGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19551""}]")]
    public class ServiceProviderPasswordRulesGetRequest13mp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderPasswordRulesGetResponse13mp2>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19551")]
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
