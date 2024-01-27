using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetListRequest14.
    /// Contains a table of devices defined at the System-level.
    /// The column headings are:
    /// "Device Name", "Device Type", "Available Ports", "Net Address" and "MAC Address", "Status", "Version", and "Access Device External Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Access Device External Id"
    /// <see cref="SystemAccessDeviceGetListRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1268""}]")]
    public class SystemAccessDeviceGetListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1268")]
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
