using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterGetAvailableDNISListRequest.
    /// Contains a list of available DNIS for agent to select.
    /// <see cref="UserCallCenterGetAvailableDNISListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7049""}]")]
    public class UserCallCenterGetAvailableDNISListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DNISKey> _availableDNIS = new List<BroadWorksConnector.Ocip.Models.DNISKey>();

        [XmlElement(ElementName = "availableDNIS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7049")]
        public List<BroadWorksConnector.Ocip.Models.DNISKey> AvailableDNIS
        {
            get => _availableDNIS;
            set
            {
                AvailableDNISSpecified = true;
                _availableDNIS = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableDNISSpecified { get; set; }

    }
}
