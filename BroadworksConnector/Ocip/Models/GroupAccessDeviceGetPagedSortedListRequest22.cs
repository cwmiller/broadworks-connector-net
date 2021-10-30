using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of access devices in a group.
    /// The response is either GroupAccessDeviceGetPagedSortedListResponse or ErrorResponse.
    /// If no sortOrder is included, the response is sorted by Device Name ascending
    /// by default.  If the responsePagingControl element is not provided, the paging startIndex
    /// will be set to 1 by default, and the responsePageSize will be set to the maximum
    /// responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the
    /// searchCriteriaModeOr option is included. Then the search criteria are logically
    /// ORed together.
    /// The getVisualDeviceManagementAPIDevicesOnly element can only be set when CloudPBX is licenced.
    /// If the getVisualDeviceManagementAPIDevicesOnly element is not set, all devices are returned with Visual Device Management API flag set to empty.
    /// If the getVisualDeviceManagementAPIDevicesOnly element is set to true, only SIP devices supporting Visual Device Management API are returned.
    /// If the getVisualDeviceManagementAPIDevicesOnly element is set to false, all SIP devices are returned with their current Visual Device Management API flag value.
    /// <see cref="GroupAccessDeviceGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1051""}]")]
    public class GroupAccessDeviceGetPagedSortedListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetPagedSortedListResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private bool _includeTotalNumberOfRows;

        [XmlElement(ElementName = "includeTotalNumberOfRows", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public bool IncludeTotalNumberOfRows
        {
            get => _includeTotalNumberOfRows;
            set
            {
                IncludeTotalNumberOfRowsSpecified = true;
                _includeTotalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTotalNumberOfRowsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
        {
            get => _responsePagingControl;
            set
            {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        protected bool ResponsePagingControlSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SortOrderGroupAccessDeviceGetPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderGroupAccessDeviceGetPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderGroupAccessDeviceGetPagedSortedList> SortOrder
        {
            get => _sortOrder;
            set
            {
                SortOrderSpecified = true;
                _sortOrder = value;
            }
        }

        [XmlIgnore]
        protected bool SortOrderSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName>();

        [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName
        {
            get => _searchCriteriaDeviceName;
            set
            {
                SearchCriteriaDeviceNameSpecified = true;
                _searchCriteriaDeviceName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> _searchCriteriaDeviceMACAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress>();

        [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress
        {
            get => _searchCriteriaDeviceMACAddress;
            set
            {
                SearchCriteriaDeviceMACAddressSpecified = true;
                _searchCriteriaDeviceMACAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceMACAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> _searchCriteriaDeviceNetAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress>();

        [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress
        {
            get => _searchCriteriaDeviceNetAddress;
            set
            {
                SearchCriteriaDeviceNetAddressSpecified = true;
                _searchCriteriaDeviceNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceNetAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType> _searchCriteriaExactDeviceType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType>();

        [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType> SearchCriteriaExactDeviceType
        {
            get => _searchCriteriaExactDeviceType;
            set
            {
                SearchCriteriaExactDeviceTypeSpecified = true;
                _searchCriteriaExactDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactDeviceTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> _searchCriteriaAccessDeviceVersion = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion>();

        [XmlElement(ElementName = "searchCriteriaAccessDeviceVersion", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> SearchCriteriaAccessDeviceVersion
        {
            get => _searchCriteriaAccessDeviceVersion;
            set
            {
                SearchCriteriaAccessDeviceVersionSpecified = true;
                _searchCriteriaAccessDeviceVersion = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaAccessDeviceVersionSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public bool SearchCriteriaModeOr
        {
            get => _searchCriteriaModeOr;
            set
            {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaModeOrSpecified { get; set; }

        private bool _getVisualDeviceManagementAPIDevicesOnly;

        [XmlElement(ElementName = "getVisualDeviceManagementAPIDevicesOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1051")]
        public bool GetVisualDeviceManagementAPIDevicesOnly
        {
            get => _getVisualDeviceManagementAPIDevicesOnly;
            set
            {
                GetVisualDeviceManagementAPIDevicesOnlySpecified = true;
                _getVisualDeviceManagementAPIDevicesOnly = value;
            }
        }

        [XmlIgnore]
        protected bool GetVisualDeviceManagementAPIDevicesOnlySpecified { get; set; }

    }
}
