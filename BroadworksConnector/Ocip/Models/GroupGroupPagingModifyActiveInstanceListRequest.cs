using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the active status of Group Paging instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:403""}]")]
    public class GroupGroupPagingModifyActiveInstanceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.ServiceActivation> _serviceActivation = new List<BroadWorksConnector.Ocip.Models.ServiceActivation>();

        [XmlElement(ElementName = "serviceActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:403")]
        public List<BroadWorksConnector.Ocip.Models.ServiceActivation> ServiceActivation
        {
            get => _serviceActivation;
            set
            {
                ServiceActivationSpecified = true;
                _serviceActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceActivationSpecified { get; set; }

    }
}
