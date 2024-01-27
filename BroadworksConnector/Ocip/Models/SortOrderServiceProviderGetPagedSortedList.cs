using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the ServiceProviderGetPagedSortedListRequest request.
    /// <see cref="ServiceProviderGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:7288""}]")]
    public class SortOrderServiceProviderGetPagedSortedList
    {

        protected BroadWorksConnector.Ocip.Models.SortByServiceProviderId _sortByServiceProviderId;

        [XmlElement(ElementName = "sortByServiceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7288")]
        public BroadWorksConnector.Ocip.Models.SortByServiceProviderId SortByServiceProviderId
        {
            get => _sortByServiceProviderId;
            set
            {
                SortByServiceProviderIdSpecified = true;
                _sortByServiceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByServiceProviderIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByServiceProviderName _sortByServiceProviderName;

        [XmlElement(ElementName = "sortByServiceProviderName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7288")]
        public BroadWorksConnector.Ocip.Models.SortByServiceProviderName SortByServiceProviderName
        {
            get => _sortByServiceProviderName;
            set
            {
                SortByServiceProviderNameSpecified = true;
                _sortByServiceProviderName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByServiceProviderNameSpecified { get; set; }

    }
}
