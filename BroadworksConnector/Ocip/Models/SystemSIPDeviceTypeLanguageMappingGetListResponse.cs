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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17519""}]")]
    public class SystemSIPDeviceTypeLanguageMappingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeLanguagesTable;

        [XmlElement(ElementName = "deviceTypeLanguagesTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17519")]
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
