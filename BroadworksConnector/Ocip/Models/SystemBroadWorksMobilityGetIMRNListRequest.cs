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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:966""}]")]
    public class SystemBroadWorksMobilityGetIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityGetIMRNListResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN>();

        [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:966")]
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
        protected bool SearchCriteriaIMRNSpecified { get; set; }

    }
}
