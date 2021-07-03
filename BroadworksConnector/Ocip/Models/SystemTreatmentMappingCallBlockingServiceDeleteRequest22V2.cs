using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Call Blocking Service mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceDeleteRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:11787""}]")]
    public class SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.CallBlockingService22V2 _callBlockingService;

        [XmlElement(ElementName = "callBlockingService", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:11787")]
        public BroadWorksConnector.Ocip.Models.CallBlockingService22V2 CallBlockingService
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

    }
}
