using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's passcode rules setting.
    /// The response is either ServiceProviderPortalPasscodeRulesGetResponse19 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderPortalPasscodeRulesGetRequest22 in AS data mode.
    /// <see cref="ServiceProviderPortalPasscodeRulesGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderPortalPasscodeRulesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dcbd2c8b4418bae71f73d8ae679071f8:45""}]")]
    public class ServiceProviderPortalPasscodeRulesGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderPortalPasscodeRulesGetResponse19>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"dcbd2c8b4418bae71f73d8ae679071f8:45")]
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
