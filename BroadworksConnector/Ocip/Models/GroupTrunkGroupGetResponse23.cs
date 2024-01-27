using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTrunkGroupGetRequest23.
    /// The response contains the maximum and bursting maximum permissible active trunk group calls for the group.
    /// <see cref="GroupTrunkGroupGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1319""}]")]
    public class GroupTrunkGroupGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
        public int MaxActiveCalls
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

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

        [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableActiveCalls
        {
            get => _maxAvailableActiveCalls;
            set
            {
                MaxAvailableActiveCallsSpecified = true;
                _maxAvailableActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAvailableActiveCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxAvailableActiveCalls;

        [XmlElement(ElementName = "burstingMaxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxAvailableActiveCalls
        {
            get => _burstingMaxAvailableActiveCalls;
            set
            {
                BurstingMaxAvailableActiveCallsSpecified = true;
                _burstingMaxAvailableActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BurstingMaxAvailableActiveCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableNumberOfBurstingBTLUs;

        [XmlElement(ElementName = "maxAvailableNumberOfBurstingBTLUs", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableNumberOfBurstingBTLUs
        {
            get => _maxAvailableNumberOfBurstingBTLUs;
            set
            {
                MaxAvailableNumberOfBurstingBTLUsSpecified = true;
                _maxAvailableNumberOfBurstingBTLUs = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAvailableNumberOfBurstingBTLUsSpecified { get; set; }

    protected int _numberOfBurstingBTLUs;

    [XmlElement(ElementName = "numberOfBurstingBTLUs", IsNullable = false, Namespace = "")]
    [Optional]
    [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1319")]
    public int NumberOfBurstingBTLUs
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
