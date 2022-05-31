using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Group Night Forwarding system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1a3849774e8d2ffd90c3a2c57cbdd7a0:132""}]")]
    public class SystemGroupNightForwardingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _nightForwardGroupCallsWithinEnterprise;

        [XmlElement(ElementName = "nightForwardGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:132")]
        public bool NightForwardGroupCallsWithinEnterprise
        {
            get => _nightForwardGroupCallsWithinEnterprise;
            set
            {
                NightForwardGroupCallsWithinEnterpriseSpecified = true;
                _nightForwardGroupCallsWithinEnterprise = value;
            }
        }

        [XmlIgnore]
        protected bool NightForwardGroupCallsWithinEnterpriseSpecified { get; set; }

    }
}
