using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of system-level access devices.
    /// The response is either SystemAccessDeviceGetPagedSortedListResponse or ErrorResponse.
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
    /// <see cref="SystemAccessDeviceGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1313"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1315"",""optional"":true}]}]")]
    public class SystemAccessDeviceGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceGetPagedSortedListResponse>
    {

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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

        private BroadWorksConnector.Ocip.Models.SortByDeviceName _sortByDeviceName;

        [XmlElement(ElementName = "sortByDeviceName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1315")]
        public BroadWorksConnector.Ocip.Models.SortByDeviceName SortByDeviceName
        {
            get => _sortByDeviceName;
            set
            {
                SortByDeviceNameSpecified = true;
                _sortByDeviceName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDeviceNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByDeviceType _sortByDeviceType;

        [XmlElement(ElementName = "sortByDeviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1315")]
        public BroadWorksConnector.Ocip.Models.SortByDeviceType SortByDeviceType
        {
            get => _sortByDeviceType;
            set
            {
                SortByDeviceTypeSpecified = true;
                _sortByDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDeviceTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByDeviceNetAddress _sortByDeviceNetAddress;

        [XmlElement(ElementName = "sortByDeviceNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1315")]
        public BroadWorksConnector.Ocip.Models.SortByDeviceNetAddress SortByDeviceNetAddress
        {
            get => _sortByDeviceNetAddress;
            set
            {
                SortByDeviceNetAddressSpecified = true;
                _sortByDeviceNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDeviceNetAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByDeviceMACAddress _sortByDeviceMACAddress;

        [XmlElement(ElementName = "sortByDeviceMACAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1315")]
        public BroadWorksConnector.Ocip.Models.SortByDeviceMACAddress SortByDeviceMACAddress
        {
            get => _sortByDeviceMACAddress;
            set
            {
                SortByDeviceMACAddressSpecified = true;
                _sortByDeviceMACAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SortByDeviceMACAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName>();

        [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1313")]
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
