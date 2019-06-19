using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the UserGetListInGroupPagedSortedListRequest request.
    /// <see cref="UserGetListInGroupPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4428""}]")]
    public class SortOrderUserGetListInGroupPagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByUserId SortByUserId
        {
            get => _sortByUserId;
            set
            {
                SortByUserIdSpecified = true;
                _sortByUserId = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByUserLastName SortByUserLastName
        {
            get => _sortByUserLastName;
            set
            {
                SortByUserLastNameSpecified = true;
                _sortByUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserLastNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName
        {
            get => _sortByUserFirstName;
            set
            {
                SortByUserFirstNameSpecified = true;
                _sortByUserFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserFirstNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

        [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName
        {
            get => _sortByDepartmentName;
            set
            {
                SortByDepartmentNameSpecified = true;
                _sortByDepartmentName = value;
            }
        }

        [XmlIgnore]
        public bool SortByDepartmentNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByDn SortByDn
        {
            get => _sortByDn;
            set
            {
                SortByDnSpecified = true;
                _sortByDn = value;
            }
        }

        [XmlIgnore]
        public bool SortByDnSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByExtension SortByExtension
        {
            get => _sortByExtension;
            set
            {
                SortByExtensionSpecified = true;
                _sortByExtension = value;
            }
        }

        [XmlIgnore]
        public bool SortByExtensionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByEmailAddress _sortByEmailAddress;

        [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4428")]
        public BroadWorksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress
        {
            get => _sortByEmailAddress;
            set
            {
                SortByEmailAddressSpecified = true;
                _sortByEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool SortByEmailAddressSpecified { get; set; }

    }
}
