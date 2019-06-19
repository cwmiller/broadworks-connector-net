using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of BroadWorks Mobility IMRN numbers defined in the system.
    /// The response is either a SystemBroadWorksMobilityGetIMRNListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityGetIMRNListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:722""}]")]
    public class SystemBroadWorksMobilityGetIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN>();

        [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:722")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN
        {
            get => _searchCriteriaIMRN;
            set
            {
                SearchCriteriaIMRNSpecified = true;
                _searchCriteriaIMRN = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaIMRNSpecified { get; set; }

    }
}
