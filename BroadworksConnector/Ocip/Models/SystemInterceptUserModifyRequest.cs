using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system-level intercept user service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:252""}]")]
    public class SystemInterceptUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _emergencyAndRepairIntercept;

        [XmlElement(ElementName = "emergencyAndRepairIntercept", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:252")]
        public bool EmergencyAndRepairIntercept
        {
            get => _emergencyAndRepairIntercept;
            set
            {
                EmergencyAndRepairInterceptSpecified = true;
                _emergencyAndRepairIntercept = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyAndRepairInterceptSpecified { get; set; }

    }
}
