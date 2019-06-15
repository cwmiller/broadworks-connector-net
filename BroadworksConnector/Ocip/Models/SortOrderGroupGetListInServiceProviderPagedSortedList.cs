using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupGetListInServiceProviderPagedSortedListRequest request.
        /// <see cref="GroupGetListInServiceProviderPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SortOrderGroupGetListInServiceProviderPagedSortedList 
    {

        
        private BroadWorksConnector.Ocip.Models.SortByGroupId _sortByGroupId;

        [XmlElement(ElementName = "sortByGroupId", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByGroupId SortByGroupId {
            get => _sortByGroupId;
            set {
                SortByGroupIdSpecified = true;
                _sortByGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SortByGroupIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByGroupName _sortByGroupName;

        [XmlElement(ElementName = "sortByGroupName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByGroupName SortByGroupName {
            get => _sortByGroupName;
            set {
                SortByGroupNameSpecified = true;
                _sortByGroupName = value;
            }
        }

        [XmlIgnore]
        public bool SortByGroupNameSpecified { get; set; }
        
    }
}
