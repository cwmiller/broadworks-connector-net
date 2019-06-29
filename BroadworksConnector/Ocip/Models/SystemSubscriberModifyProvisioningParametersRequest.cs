using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system provisioning configuration for all subscribers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17153""}]")]
    public class SystemSubscriberModifyProvisioningParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17153")]
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
