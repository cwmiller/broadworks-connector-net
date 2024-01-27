using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetAvailableCustomTagListRequest.
    /// Contains a table of all available custom tags managed by the Device Management System on a per-device profile basis.
    /// 
    /// In AS data mode, the column headings are: "Tag Name", "Tag Value", "Tag Level", "Tag Set Name", "Region Name".
    /// 
    /// In XS data mode, the column headings are: "Tag Name", "Tag Value", "Tag Level", "Tag Set Name", "Is Encrypted".
    /// 
    /// "Tag Level" can take the value: "System Default", "System", "Service Provider", "Group" or "Device Profile".
    /// <see cref="SystemAccessDeviceGetAvailableCustomTagListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1142""}]")]
    public class SystemAccessDeviceGetAvailableCustomTagListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceAvailableCustomTagsTable;

        [XmlElement(ElementName = "deviceAvailableCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1142")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceAvailableCustomTagsTable
        {
            get => _deviceAvailableCustomTagsTable;
            set
            {
                DeviceAvailableCustomTagsTableSpecified = true;
                _deviceAvailableCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAvailableCustomTagsTableSpecified { get; set; }

    }
}
