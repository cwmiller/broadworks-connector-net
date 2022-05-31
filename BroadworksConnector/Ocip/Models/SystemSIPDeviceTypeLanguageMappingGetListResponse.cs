using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeLanguageMappingGetListRequest.
    /// Contains a table of device type languages mapped to equivalent BroadWorks languages.
    /// The column headings are: "BroadWorks Language", "Device Language".
    /// <see cref="SystemSIPDeviceTypeLanguageMappingGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17292""}]")]
    public class SystemSIPDeviceTypeLanguageMappingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeLanguagesTable;

        [XmlElement(ElementName = "deviceTypeLanguagesTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17292")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeLanguagesTable
        {
            get => _deviceTypeLanguagesTable;
            set
            {
                DeviceTypeLanguagesTableSpecified = true;
                _deviceTypeLanguagesTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeLanguagesTableSpecified { get; set; }

    }
}
