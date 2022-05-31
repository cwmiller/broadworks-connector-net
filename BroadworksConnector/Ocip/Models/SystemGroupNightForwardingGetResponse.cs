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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1a3849774e8d2ffd90c3a2c57cbdd7a0:116""}]")]
    public class SystemGroupNightForwardingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _nightForwardInterGroupCallsWithinEnterprise;

        [XmlElement(ElementName = "nightForwardInterGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:116")]
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
