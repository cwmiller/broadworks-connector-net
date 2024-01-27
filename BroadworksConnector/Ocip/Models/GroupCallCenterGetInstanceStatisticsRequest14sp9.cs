using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Call Center queue and agent statistics.
    /// The response is either GroupCallCenterGetInstanceStatisticsResponse14sp9 or ErrorResponse.
    /// <see cref="GroupCallCenterGetInstanceStatisticsResponse14sp9"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4713""}]")]
    public class GroupCallCenterGetInstanceStatisticsRequest14sp9 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetInstanceStatisticsResponse14sp9>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4713")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange _statisticsRange;

        [XmlElement(ElementName = "statisticsRange", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4713")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange
        {
            get => _statisticsRange;
            set
            {
                StatisticsRangeSpecified = true;
                _statisticsRange = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsRangeSpecified { get; set; }

    }
}
