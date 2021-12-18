using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Used to sort the GroupAccessDeviceGetPagedSortedListRequest request.
    /// <see cref="GroupAccessDeviceGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:9086""}]")]
    public class SortOrderGroupAccessDeviceGetPagedSortedList
    {

        private BroadWorksConnector.Ocip.Models.SortByDeviceName _sortByDeviceName;

        [XmlElement(ElementName = "sortByDeviceName", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:9086")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:9086")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:9086")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:9086")]
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

    }
}
