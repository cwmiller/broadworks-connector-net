using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderNumberPortabilityQueryGetRequest.
    /// The response contains the service provider number portability query information.
    /// <see cref="ServiceProviderNumberPortabilityQueryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4316""}]")]
    public class ServiceProviderNumberPortabilityQueryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableNumberPortabilityQueryForOutgoingCalls;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4316")]
        public bool EnableNumberPortabilityQueryForOutgoingCalls
        {
            get => _enableNumberPortabilityQueryForOutgoingCalls;
            set
            {
                EnableNumberPortabilityQueryForOutgoingCallsSpecified = true;
                _enableNumberPortabilityQueryForOutgoingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForOutgoingCallsSpecified { get; set; }

        private bool _enableNumberPortabilityQueryForIncomingCalls;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForIncomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4316")]
        public bool EnableNumberPortabilityQueryForIncomingCalls
        {
            get => _enableNumberPortabilityQueryForIncomingCalls;
            set
            {
                EnableNumberPortabilityQueryForIncomingCallsSpecified = true;
                _enableNumberPortabilityQueryForIncomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForIncomingCallsSpecified { get; set; }

        private bool _enableNumberPortabilityQueryForNetworkCallsOnly;

        [XmlElement(ElementName = "enableNumberPortabilityQueryForNetworkCallsOnly", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4316")]
        public bool EnableNumberPortabilityQueryForNetworkCallsOnly
        {
            get => _enableNumberPortabilityQueryForNetworkCallsOnly;
            set
            {
                EnableNumberPortabilityQueryForNetworkCallsOnlySpecified = true;
                _enableNumberPortabilityQueryForNetworkCallsOnly = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNumberPortabilityQueryForNetworkCallsOnlySpecified { get; set; }

        private List<string> _digitPattern = new List<string>();

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4316")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DigitPattern
        {
            get => _digitPattern;
            set
            {
                DigitPatternSpecified = true;
                _digitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DigitPatternSpecified { get; set; }

    }
}
