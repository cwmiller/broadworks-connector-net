using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceFamilyGetListRequest.
    /// The response includes a table of device family defined in the system.
    /// Column headings are: "Device Family Name", "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemDeviceFamilyGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7471""}]")]
    public class SystemDeviceFamilyGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFamilyTable;

        [XmlElement(ElementName = "deviceFamilyTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7471")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeviceFamilyTable
        {
            get => _deviceFamilyTable;
            set
            {
                DeviceFamilyTableSpecified = true;
                _deviceFamilyTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFamilyTableSpecified { get; set; }

    }
}
