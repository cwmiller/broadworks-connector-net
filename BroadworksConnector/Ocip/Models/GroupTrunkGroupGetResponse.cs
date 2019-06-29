using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupTrunkGroupGetRequest.
    /// The response contains the maximum permissible active trunk group calls for the group.
    /// <see cref="GroupTrunkGroupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2807""}]")]
    public class GroupTrunkGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2807")]
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

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

        [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2807")]
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

    }
}
