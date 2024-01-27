using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderBroadWorksCommunicatorGetRequest.
    /// <see cref="ServiceProviderBroadWorksCommunicatorGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b4095e83c8aa84e850615ffe7d48b0d6:57""}]")]
    public class ServiceProviderBroadWorksCommunicatorGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _configurationServerURL;

        [XmlElement(ElementName = "configurationServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b4095e83c8aa84e850615ffe7d48b0d6:57")]
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
