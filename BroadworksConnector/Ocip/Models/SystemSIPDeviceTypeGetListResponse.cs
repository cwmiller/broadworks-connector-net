using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeGetListRequest.
    /// Contains a table of identity/ device profile types configured in the system.
    /// The column headings are: "Device Type", "Profile", "Is Obsolete" and "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemSIPDeviceTypeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17373""}]")]
    public class SystemSIPDeviceTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeTable;

        [XmlElement(ElementName = "deviceTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17373")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeTable
        {
            get => _deviceTypeTable;
            set
            {
                DeviceTypeTableSpecified = true;
                _deviceTypeTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeTableSpecified { get; set; }

    }
}
