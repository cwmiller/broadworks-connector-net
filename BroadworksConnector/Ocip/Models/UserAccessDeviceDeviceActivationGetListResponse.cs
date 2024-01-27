using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAccessDeviceDeviceActivationGetListRequest.
    /// Contains a table of devices supporting device activation associated to a user.
    /// The column headings are: "Device Name", "Device Level", "Device SP", "Device Group", "Endpoint Type", "Line Port", "Activation Status", "Activation Code", "Expiration Time" and "MAC Address".
    /// <see cref="UserAccessDeviceDeviceActivationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:188""}]")]
    public class UserAccessDeviceDeviceActivationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:188")]
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
