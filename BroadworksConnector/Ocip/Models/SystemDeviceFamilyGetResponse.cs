using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceFamilyGetRequest.
    /// The response includes the tag sets and device types associated to a device family defined in the system.
    /// Column headings for deviceTypeTable are : Device Type(s)
    /// Column headings for tagSetTable are :Tag Set(s)
    /// <see cref="SystemDeviceFamilyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7506""}]")]
    public class SystemDeviceFamilyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeTable;

        [XmlElement(ElementName = "deviceTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7506")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _tagSetTable;

        [XmlElement(ElementName = "tagSetTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7506")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TagSetTable
        {
            get => _tagSetTable;
            set
            {
                TagSetTableSpecified = true;
                _tagSetTable = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetTableSpecified { get; set; }

    }
}
