using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of all enterprise trunk number ranges in the system.
    /// If resellerId is specified, the number ranges assigned to the enterprises/service providers
    /// within the reseller are returned.
    /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// 
    /// The response is either SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
    /// <see cref="SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:743""}]")]
    public class SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:743")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

    }
}
