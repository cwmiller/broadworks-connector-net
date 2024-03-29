using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get Call Center queue and agent statistics.
    /// The response is either GroupCallCenterGetInstanceStatisticsResponse13mp8 or ErrorResponse.
    /// Replaced By: GroupCallCenterGetInstanceStatisticsRequest14sp9
    /// <see cref="GroupCallCenterGetInstanceStatisticsResponse13mp8"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterGetInstanceStatisticsRequest14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6290""}]")]
    public class GroupCallCenterGetInstanceStatisticsRequest13mp8 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetInstanceStatisticsResponse13mp8>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6290")]
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

    }
}
