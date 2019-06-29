using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetProvisioningParametersRequest.
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17082""}]")]
    public class SystemSubscriberGetProvisioningParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17082")]
        public bool ConfigurableCLIDNormalization
        {
            get => _configurableCLIDNormalization;
            set
            {
                ConfigurableCLIDNormalizationSpecified = true;
                _configurableCLIDNormalization = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurableCLIDNormalizationSpecified { get; set; }

    }
}
