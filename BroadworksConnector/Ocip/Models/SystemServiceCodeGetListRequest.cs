using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all service codes that have been defined in the system.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// Multiple search criteria are logically ANDed together.
    /// The response is either SystemServiceCodeGetListResponse or ErrorResponse.
    /// <see cref="SystemServiceCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16107""}]")]
    public class SystemServiceCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemServiceCodeGetListResponse>
    {

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16107")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCode> _searchCriteriaServiceCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCode>();

        [XmlElement(ElementName = "searchCriteriaServiceCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16107")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCode> SearchCriteriaServiceCode
        {
            get => _searchCriteriaServiceCode;
            set
            {
                SearchCriteriaServiceCodeSpecified = true;
                _searchCriteriaServiceCode = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceCodeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> _searchCriteriaServiceCodeDescription = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription>();

        [XmlElement(ElementName = "searchCriteriaServiceCodeDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16107")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> SearchCriteriaServiceCodeDescription
        {
            get => _searchCriteriaServiceCodeDescription;
            set
            {
                SearchCriteriaServiceCodeDescriptionSpecified = true;
                _searchCriteriaServiceCodeDescription = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceCodeDescriptionSpecified { get; set; }

    }
}
