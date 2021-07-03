using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest.
    /// Contains a table of devices can be assigned to session admission control group in the enterprise.
    /// <see cref="EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:901""}]")]
    public class EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _accessDevice = new List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice>();

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:901")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceSpecified { get; set; }

    }
}
