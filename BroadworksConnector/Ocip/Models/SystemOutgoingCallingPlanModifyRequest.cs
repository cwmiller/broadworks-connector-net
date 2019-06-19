using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Outgoing Calling Plan.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1001""}]")]
    public class SystemOutgoingCallingPlanModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1001")]
        public bool DirectTransferScreening
        {
            get => _directTransferScreening;
            set
            {
                DirectTransferScreeningSpecified = true;
                _directTransferScreening = value;
            }
        }

        [XmlIgnore]
        public bool DirectTransferScreeningSpecified { get; set; }

        private bool _enableEnhancedTollCallTyping;

        [XmlElement(ElementName = "enableEnhancedTollCallTyping", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1001")]
        public bool EnableEnhancedTollCallTyping
        {
            get => _enableEnhancedTollCallTyping;
            set
            {
                EnableEnhancedTollCallTypingSpecified = true;
                _enableEnhancedTollCallTyping = value;
            }
        }

        [XmlIgnore]
        public bool EnableEnhancedTollCallTypingSpecified { get; set; }

    }
}
