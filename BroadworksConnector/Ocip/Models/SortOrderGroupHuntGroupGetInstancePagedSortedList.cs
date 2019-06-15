using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupHuntGroupGetInstancePagedSortedListRequest request.
        /// <see cref="GroupHuntGroupGetInstancePagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SortOrderGroupHuntGroupGetInstancePagedSortedList 
    {

        
        private BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByUserId SortByUserId {
            get => _sortByUserId;
            set {
                SortByUserIdSpecified = true;
                _sortByUserId = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByUserLastName SortByUserLastName {
            get => _sortByUserLastName;
            set {
                SortByUserLastNameSpecified = true;
                _sortByUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserLastNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByDn SortByDn {
            get => _sortByDn;
            set {
                SortByDnSpecified = true;
                _sortByDn = value;
            }
        }

        [XmlIgnore]
        public bool SortByDnSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByExtension SortByExtension {
            get => _sortByExtension;
            set {
                SortByExtensionSpecified = true;
                _sortByExtension = value;
            }
        }

        [XmlIgnore]
        public bool SortByExtensionSpecified { get; set; }
        
    }
}
