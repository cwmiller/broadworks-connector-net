using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Two Stage Dialing dns defined in the system.
    /// The response is either a SystemTwoStageDialingGetDnListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemTwoStageDialingGetDnListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a1428f64736d8f970ea802e5a73c495:80""}]")]
    public class SystemTwoStageDialingGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTwoStageDialingGetDnListResponse>
    {

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2a1428f64736d8f970ea802e5a73c495:80")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> _searchCriteriaSystemServiceDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn>();

        [XmlElement(ElementName = "searchCriteriaSystemServiceDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2a1428f64736d8f970ea802e5a73c495:80")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> SearchCriteriaSystemServiceDn
        {
            get => _searchCriteriaSystemServiceDn;
            set
            {
                SearchCriteriaSystemServiceDnSpecified = true;
                _searchCriteriaSystemServiceDn = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaSystemServiceDnSpecified { get; set; }

    }
}
