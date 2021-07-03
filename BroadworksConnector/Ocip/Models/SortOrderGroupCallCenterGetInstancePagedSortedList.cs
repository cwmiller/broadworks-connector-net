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

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7847""}]")]
    public class SortOrderGroupCallCenterGetInstancePagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByUserId _sortByUserId;

        [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByCallCenterName _sortByCallCenterName;

        [XmlElement(ElementName = "sortByCallCenterName", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

        [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByHuntPolicy _sortByHuntPolicy;

        [XmlElement(ElementName = "sortByHuntPolicy", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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

        private BroadWorksConnector.Ocip.Models.SortByCallCenterType _sortByCallCenterType;

        [XmlElement(ElementName = "sortByCallCenterType", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7847")]
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
