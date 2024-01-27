using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetNativeTagsWithLogicListRequest.
    /// Contains a table of all native tags with logic managed by the Device Management System on a per-device profile basis.
    /// 
    /// The column headings are: "Tag Name", "Tag Value".
    /// <see cref="GroupAccessDeviceGetNativeTagsWithLogicListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1024""}]")]
    public class GroupAccessDeviceGetNativeTagsWithLogicListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceNativeTagsWithLogicTable;

        [XmlElement(ElementName = "deviceNativeTagsWithLogicTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1024")]
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
