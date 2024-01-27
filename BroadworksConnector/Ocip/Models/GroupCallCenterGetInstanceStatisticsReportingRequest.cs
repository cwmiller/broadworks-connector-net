using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the call center statistics reporting settings.
    /// The response is either GroupCallCenterGetInstanceStatisticsReportingResponse or ErrorResponse.
    /// 
    /// Replaced By: GroupCallCenterGetInstanceStatisticsReportingRequest16
    /// <see cref="GroupCallCenterGetInstanceStatisticsReportingResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterGetInstanceStatisticsReportingRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6220""}]")]
    public class GroupCallCenterGetInstanceStatisticsReportingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetInstanceStatisticsReportingResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6220")]
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
