using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Remove a device type to be monitored.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1154"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1155""}]}]")]
    public class SystemAccessDeviceMonitorDeleteDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _deleteAllDeviceTypes;

        [XmlElement(ElementName = "deleteAllDeviceTypes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1155")]
        public bool DeleteAllDeviceTypes
        {
            get => _deleteAllDeviceTypes;
            set
            {
                DeleteAllDeviceTypesSpecified = true;
                _deleteAllDeviceTypes = value;
            }
        }

        [XmlIgnore]
        public bool DeleteAllDeviceTypesSpecified { get; set; }

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1155")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }

    }
}
