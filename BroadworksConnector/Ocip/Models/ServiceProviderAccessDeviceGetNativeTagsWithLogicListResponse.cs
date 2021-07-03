using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequest.
    /// Contains a table of all native tags with logic managed by the Device Management System on a per-device profile basis.
    /// 
    /// The column headings are: "Tag Name", "Tag Value".
    /// <see cref="ServiceProviderAccessDeviceGetNativeTagsWithLogicListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:881""}]")]
    public class ServiceProviderAccessDeviceGetNativeTagsWithLogicListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceNativeTagsWithLogicTable;

        [XmlElement(ElementName = "deviceNativeTagsWithLogicTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:881")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceNativeTagsWithLogicTable
        {
            get => _deviceNativeTagsWithLogicTable;
            set
            {
                DeviceNativeTagsWithLogicTableSpecified = true;
                _deviceNativeTagsWithLogicTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNativeTagsWithLogicTableSpecified { get; set; }

    }
}
