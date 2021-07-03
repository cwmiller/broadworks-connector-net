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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:189""}]")]
    public class UserAccessDeviceDeviceActivationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

        [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:189")]
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
