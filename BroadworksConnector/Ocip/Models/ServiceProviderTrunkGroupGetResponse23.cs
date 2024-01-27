using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderTrunkGroupGetRequest23.
    /// The response contains the maximum and bursting maximum permissible active trunk group calls for the service provider.
    /// <see cref="ServiceProviderTrunkGroupGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1630""}]")]
    public class ServiceProviderTrunkGroupGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1630")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt MaxActiveCalls
        {
            get => _maxActiveCalls;
            set
            {
                MaxActiveCallsSpecified = true;
                _maxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxActiveCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1630")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxActiveCalls
        {
            get => _burstingMaxActiveCalls;
            set
            {
                BurstingMaxActiveCallsSpecified = true;
                _burstingMaxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BurstingMaxActiveCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _numberOfBurstingBTLUs;

        [XmlElement(ElementName = "numberOfBurstingBTLUs", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1630")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt NumberOfBurstingBTLUs
        {
            get => _numberOfBurstingBTLUs;
            set
            {
                NumberOfBurstingBTLUsSpecified = true;
                _numberOfBurstingBTLUs = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfBurstingBTLUsSpecified { get; set; }

    }
}
