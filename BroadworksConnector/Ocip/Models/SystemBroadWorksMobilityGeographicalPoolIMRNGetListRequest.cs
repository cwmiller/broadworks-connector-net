using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of BroadWorks Mobility IMRN numbers from a geographical pool.
    /// The response is either a SystemBroadWorksMobilityGeographicalPoolIMRNGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityGeographicalPoolIMRNGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:847""}]")]
    public class SystemBroadWorksMobilityGeographicalPoolIMRNGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityGeographicalPoolIMRNGetListResponse>
    {

        protected string _geographicalPoolName;

        [XmlElement(ElementName = "geographicalPoolName", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:847")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GeographicalPoolName
        {
            get => _geographicalPoolName;
            set
            {
                GeographicalPoolNameSpecified = true;
                _geographicalPoolName = value;
            }
        }

        [XmlIgnore]
        protected bool GeographicalPoolNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN>();

        [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:847")]
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
