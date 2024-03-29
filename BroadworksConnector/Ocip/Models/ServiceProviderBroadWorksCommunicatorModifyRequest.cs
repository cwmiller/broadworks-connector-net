using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b4095e83c8aa84e850615ffe7d48b0d6:72""}]")]
    public class ServiceProviderBroadWorksCommunicatorModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b4095e83c8aa84e850615ffe7d48b0d6:72")]
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

        protected string _configurationServerURL;

        [XmlElement(ElementName = "configurationServerURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b4095e83c8aa84e850615ffe7d48b0d6:72")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationServerURL
        {
            get => _configurationServerURL;
            set
            {
                ConfigurationServerURLSpecified = true;
                _configurationServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationServerURLSpecified { get; set; }

    }
}
