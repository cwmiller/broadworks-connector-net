using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceTypeGetEnhancedConfigurableListRequest.
    /// Contains a table with columns: "Access Device Type", "Enhanced Configuration Type", "Supports Reset".
    /// The "Enhanced Configuration Type" column contains one of the AccessDeviceEnhancedConfigurationType14
    /// enumerated values.
    /// The "Supports Reset" column is a boolean flag indicating the device can be remotely reset.
    /// <see cref="SystemAccessDeviceTypeGetEnhancedConfigurableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1331""}]")]
    public class SystemAccessDeviceTypeGetEnhancedConfigurableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeTable;

        [XmlElement(ElementName = "deviceTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1331")]
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
