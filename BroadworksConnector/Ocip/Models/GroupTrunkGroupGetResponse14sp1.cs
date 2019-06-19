using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTrunkGroupGetRequest14sp1.
    /// The response contains the maximum and bursting maximum permissible active trunk group calls for the
    /// group.
    /// <see cref="GroupTrunkGroupGetRequest14sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2825""}]")]
    public class GroupTrunkGroupGetResponse14sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2825")]
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
        public bool MaxActiveCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

        [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2825")]
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
        public bool MaxAvailableActiveCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2825")]
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
        public bool BurstingMaxActiveCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxAvailableActiveCalls;

        [XmlElement(ElementName = "burstingMaxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2825")]
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
        public bool BurstingMaxAvailableActiveCallsSpecified { get; set; }

    }
}
