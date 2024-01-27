using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the ServiceProviderAdminGetPagedSortedListRequest request.
    /// <see cref="ServiceProviderAdminGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:7275""}]")]
    public class SortOrderServiceProviderAdminGetPagedSortedList
    {

        protected BroadWorksConnector.Ocip.Models.SortByAdminId _sortByAdminId;

        [XmlElement(ElementName = "sortByAdminId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7275")]
        public BroadWorksConnector.Ocip.Models.SortByAdminId SortByAdminId
        {
            get => _sortByAdminId;
            set
            {
                SortByAdminIdSpecified = true;
                _sortByAdminId = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByAdminLastName _sortByAdminLastName;

        [XmlElement(ElementName = "sortByAdminLastName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7275")]
        public BroadWorksConnector.Ocip.Models.SortByAdminLastName SortByAdminLastName
        {
            get => _sortByAdminLastName;
            set
            {
                SortByAdminLastNameSpecified = true;
                _sortByAdminLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminLastNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByAdminFirstName _sortByAdminFirstName;

        [XmlElement(ElementName = "sortByAdminFirstName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7275")]
        public BroadWorksConnector.Ocip.Models.SortByAdminFirstName SortByAdminFirstName
        {
            get => _sortByAdminFirstName;
            set
            {
                SortByAdminFirstNameSpecified = true;
                _sortByAdminFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByAdminFirstNameSpecified { get; set; }

    }
}
