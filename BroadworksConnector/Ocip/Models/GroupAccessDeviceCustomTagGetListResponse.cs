using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device profile basis.
    /// In AS data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value".
    /// In XS data mode, the column headings are:
    /// "Tag Name", "Tag Value", "Actual Tag Value" if request is invoked by an admin without system privileges.
    /// "Tag Name", "Tag Value", "Is Encrypted", "Actual Tag Value" if request is invoked by an admin with system privileges.
    /// <see cref="GroupAccessDeviceCustomTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:449""}]")]
    public class GroupAccessDeviceCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceCustomTagsTable;

        [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:449")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceCustomTagsTable
        {
            get => _deviceCustomTagsTable;
            set
            {
                DeviceCustomTagsTableSpecified = true;
                _deviceCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceCustomTagsTableSpecified { get; set; }

    }
}
