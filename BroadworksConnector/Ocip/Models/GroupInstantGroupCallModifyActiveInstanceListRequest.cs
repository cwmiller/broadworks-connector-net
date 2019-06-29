using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the active status of Instant Group Call service instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f41dea4708922d4a3f0e26f198cc953f:158""}]")]
    public class GroupInstantGroupCallModifyActiveInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.ServiceActivation> _serviceActivation = new List<BroadWorksConnector.Ocip.Models.ServiceActivation>();

        [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f41dea4708922d4a3f0e26f198cc953f:158")]
        public List<BroadWorksConnector.Ocip.Models.ServiceActivation> ServiceActivation
        {
            get => _serviceActivation;
            set
            {
                ServiceActivationSpecified = true;
                _serviceActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceActivationSpecified { get; set; }

    }
}
