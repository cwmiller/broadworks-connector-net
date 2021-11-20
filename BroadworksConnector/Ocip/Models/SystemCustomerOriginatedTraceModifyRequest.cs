using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Customer Originated Trace.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""55636b88804490cf0ead7c9d4f44f28d:73""}]")]
    public class SystemCustomerOriginatedTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _screenMaliciousCallers;

        [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"55636b88804490cf0ead7c9d4f44f28d:73")]
        public bool ScreenMaliciousCallers
        {
            get => _screenMaliciousCallers;
            set
            {
                ScreenMaliciousCallersSpecified = true;
                _screenMaliciousCallers = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenMaliciousCallersSpecified { get; set; }

    }
}
