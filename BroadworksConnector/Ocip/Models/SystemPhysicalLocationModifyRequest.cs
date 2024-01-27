using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Physical Location system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8250786d50d10f8fe081d126ecca3847:73""}]")]
    public class SystemPhysicalLocationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _alwaysAllowEmergencyCalls;

        [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8250786d50d10f8fe081d126ecca3847:73")]
        public bool AlwaysAllowEmergencyCalls
        {
            get => _alwaysAllowEmergencyCalls;
            set
            {
                AlwaysAllowEmergencyCallsSpecified = true;
                _alwaysAllowEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysAllowEmergencyCallsSpecified { get; set; }

    }
}
