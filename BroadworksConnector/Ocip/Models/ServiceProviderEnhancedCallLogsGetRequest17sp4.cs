using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider's enhanced call log settings.
    /// The response is either a ServiceProviderEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
    /// This command will return an ErrorResponse if DBS is used as the call log server.
    /// <see cref="ServiceProviderEnhancedCallLogsGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:104""}]")]
    public class ServiceProviderEnhancedCallLogsGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderEnhancedCallLogsGetResponse17sp4>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:104")]
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
