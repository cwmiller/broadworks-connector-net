using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device profile basis.
    /// 
    /// In AS data mode, the column headings are: "Tag Name", "Tag Value", "Actual Tag Value".
    /// In XS data mode, the column headings are: "Tag Name", "Tag Value", "Is Encrypted", "Actual Tag Value".
    /// <see cref="SystemAccessDeviceCustomTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:834""}]")]
    public class SystemAccessDeviceCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceCustomTagsTable;

        [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:834")]
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
