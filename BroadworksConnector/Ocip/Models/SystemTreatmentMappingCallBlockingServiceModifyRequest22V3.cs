using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the fields for a Call Blocking Service mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12074""}]")]
    public class SystemTreatmentMappingCallBlockingServiceModifyRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.CallBlockingService22V3 _callBlockingService;

        [XmlElement(ElementName = "callBlockingService", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12074")]
        public BroadWorksConnector.Ocip.Models.CallBlockingService22V3 CallBlockingService
        {
            get => _callBlockingService;
            set
            {
                CallBlockingServiceSpecified = true;
                _callBlockingService = value;
            }
        }

        [XmlIgnore]
        protected bool CallBlockingServiceSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12074")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

    }
}
