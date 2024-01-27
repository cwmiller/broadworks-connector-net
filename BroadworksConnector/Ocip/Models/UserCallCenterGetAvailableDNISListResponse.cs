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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7035""}]")]
    public class UserCallCenterGetAvailableDNISListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DNISKey> _availableDNIS = new List<BroadWorksConnector.Ocip.Models.DNISKey>();

        [XmlElement(ElementName = "availableDNIS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7035")]
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
