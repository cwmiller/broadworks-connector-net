using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupGetListInServiceProviderPagedSortedListRequest request.
    /// <see cref="GroupGetListInServiceProviderPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8851""}]")]
    public class SortOrderGroupGetListInServiceProviderPagedSortedList
    {

        protected BroadWorksConnector.Ocip.Models.SortByGroupId _sortByGroupId;

        [XmlElement(ElementName = "sortByGroupId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8851")]
        public BroadWorksConnector.Ocip.Models.SortByGroupId SortByGroupId
        {
            get => _sortByGroupId;
            set
            {
                SortByGroupIdSpecified = true;
                _sortByGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByGroupName _sortByGroupName;

        [XmlElement(ElementName = "sortByGroupName", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8851")]
        public BroadWorksConnector.Ocip.Models.SortByGroupName SortByGroupName
        {
            get => _sortByGroupName;
            set
            {
                SortByGroupNameSpecified = true;
                _sortByGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupNameSpecified { get; set; }

    }
}
