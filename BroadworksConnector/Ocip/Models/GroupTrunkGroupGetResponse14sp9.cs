using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTrunkGroupGetRequest14sp9.
    /// The response contains the maximum and bursting maximum permissible active trunk group calls for the group.
    /// 
    /// Deprecated by GroupTrunkGroupGetResponse23
    /// <see cref="GroupTrunkGroupGetRequest14sp9"/>
    /// <see cref="GroupTrunkGroupGetResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15614""}]")]
    public class GroupTrunkGroupGetResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15614")]
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

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

        [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15614")]
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

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15614")]
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

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxAvailableActiveCalls;

        [XmlElement(ElementName = "burstingMaxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15614")]
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

    }
}
