using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add one or more devices to an enterprise level session admission control group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:916""}]")]
    public class EnterpriseSessionAdmissionControlGroupAddDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:916")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:916")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _devices = new List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice>();

        [XmlElement(ElementName = "devices", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:916")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Devices
        {
            get => _devices;
            set
            {
                DevicesSpecified = true;
                _devices = value;
            }
        }

        [XmlIgnore]
        public bool DevicesSpecified { get; set; }

    }
}
