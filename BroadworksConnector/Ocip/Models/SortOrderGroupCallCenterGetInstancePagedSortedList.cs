using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupCallCenterGetInstancePagedSortedListRequest request.
    /// <see cref="GroupCallCenterGetInstancePagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7833""}]")]
    public class SortOrderGroupCallCenterGetInstancePagedSortedList
    {

        protected BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
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
        protected bool SortByUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByCallCenterName _sortByCallCenterName;

        [XmlElement(ElementName = "sortByCallCenterName", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
        public BroadWorksConnector.Ocip.Models.SortByCallCenterName SortByCallCenterName
        {
            get => _sortByCallCenterName;
            set
            {
                SortByCallCenterNameSpecified = true;
                _sortByCallCenterName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByCallCenterNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
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
        protected bool SortByDnSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
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
        protected bool SortByExtensionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

        [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
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
        protected bool SortByDepartmentNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByHuntPolicy _sortByHuntPolicy;

        [XmlElement(ElementName = "sortByHuntPolicy", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
        public BroadWorksConnector.Ocip.Models.SortByHuntPolicy SortByHuntPolicy
        {
            get => _sortByHuntPolicy;
            set
            {
                SortByHuntPolicySpecified = true;
                _sortByHuntPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SortByHuntPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByCallCenterType _sortByCallCenterType;

        [XmlElement(ElementName = "sortByCallCenterType", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7833")]
        public BroadWorksConnector.Ocip.Models.SortByCallCenterType SortByCallCenterType
        {
            get => _sortByCallCenterType;
            set
            {
                SortByCallCenterTypeSpecified = true;
                _sortByCallCenterType = value;
            }
        }

        [XmlIgnore]
        protected bool SortByCallCenterTypeSpecified { get; set; }

    }
}
