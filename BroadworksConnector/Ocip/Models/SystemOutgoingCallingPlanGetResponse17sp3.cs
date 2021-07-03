using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOutgoingCallingPlanGetRequest17sp3.
    /// <see cref="SystemOutgoingCallingPlanGetRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:985""}]")]
    public class SystemOutgoingCallingPlanGetResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:985")]
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
        protected bool DirectTransferScreeningSpecified { get; set; }

        private bool _enableEnhancedTollCallTyping;

        [XmlElement(ElementName = "enableEnhancedTollCallTyping", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:985")]
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
        protected bool EnableEnhancedTollCallTypingSpecified { get; set; }

    }
}
