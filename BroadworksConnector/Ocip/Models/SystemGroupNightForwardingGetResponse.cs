using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGroupNightForwardingGetRequest.
    /// <see cref="SystemGroupNightForwardingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65f35694d7d3354987bf6387ab55bfc6:116""}]")]
    public class SystemGroupNightForwardingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _nightForwardInterGroupCallsWithinEnterprise;

        [XmlElement(ElementName = "nightForwardInterGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"65f35694d7d3354987bf6387ab55bfc6:116")]
        public bool NightForwardInterGroupCallsWithinEnterprise
        {
            get => _nightForwardInterGroupCallsWithinEnterprise;
            set
            {
                NightForwardInterGroupCallsWithinEnterpriseSpecified = true;
                _nightForwardInterGroupCallsWithinEnterprise = value;
            }
        }

        [XmlIgnore]
        protected bool NightForwardInterGroupCallsWithinEnterpriseSpecified { get; set; }

    }
}
