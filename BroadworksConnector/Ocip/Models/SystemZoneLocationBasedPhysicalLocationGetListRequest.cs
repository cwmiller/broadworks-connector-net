using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of physical locations assigned to a zone.
    /// Response is SystemZoneLocationBasedPhysicalLocationGetListResponse or an ErrorResponse.
    /// <see cref="SystemZoneLocationBasedPhysicalLocationGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:20408""}]")]
    public class SystemZoneLocationBasedPhysicalLocationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemZoneLocationBasedPhysicalLocationGetListResponse>
    {

        protected string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:20408")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ZoneName
        {
            get => _zoneName;
            set
            {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        protected bool ZoneNameSpecified { get; set; }

        protected int? _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:20408")]
        [MinInclusive(1)]
        public int? ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = (value != null);
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaPhysicalLocation> _searchCriteriaPhysicalLocation = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaPhysicalLocation>();

        [XmlElement(ElementName = "searchCriteriaPhysicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:20408")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaPhysicalLocation> SearchCriteriaPhysicalLocation
        {
            get => _searchCriteriaPhysicalLocation;
            set
            {
                SearchCriteriaPhysicalLocationSpecified = (value != null);
                _searchCriteriaPhysicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaPhysicalLocationSpecified { get; set; }

    }
}
