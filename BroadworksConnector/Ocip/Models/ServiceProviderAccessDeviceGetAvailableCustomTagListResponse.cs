using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetAvailableCustomTagListRequest.
    /// Contains a table of all available custom tags managed by the Device Management System on a per-device profile basis.
    /// 
    /// In AS data mode, the column headings are: "Tag Name", "Tag Value", "Tag Level", "Tag Set Name", "Region Name".
    /// 
    /// In XS data mode:
    /// the column headings are: "Tag Name", "Tag Value", "Tag Level", "Tag Set Name", "Is Encrypted" if request is invoked by a System administrator or by an administrator with higher priviledges, otherwise the column headings are: "Tag Name", "Tag Value", "Tag Level", "Tag Source", "Tag Set Name".
    /// 
    /// "Tag Level" can take the value: "System Default", "System", "Service Provider", "Group" or "Device Profile".
    /// <see cref="ServiceProviderAccessDeviceGetAvailableCustomTagListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:655""}]")]
    public class ServiceProviderAccessDeviceGetAvailableCustomTagListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceAvailableCustomTagsTable;

        [XmlElement(ElementName = "deviceAvailableCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:655")]
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
