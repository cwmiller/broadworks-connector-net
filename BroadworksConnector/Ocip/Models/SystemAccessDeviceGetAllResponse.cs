using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetAllRequest.
    /// Contains a table of devices configured in the entire system.
    /// The column headings are: "Service Provider Id", "Is Enterprise", "Group Id",
    /// "Device Name", "Device Type", "Net Address", "MAC Address", "Status", "Reseller Id",
    /// "Access Device External Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// "Access Device External Id"
    /// <see cref="SystemAccessDeviceGetAllRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1101""}]")]
    public class SystemAccessDeviceGetAllResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1101")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AccessDeviceTable
        {
            get => _accessDeviceTable;
            set
            {
                AccessDeviceTableSpecified = true;
                _accessDeviceTable = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceTableSpecified { get; set; }

    }
}
