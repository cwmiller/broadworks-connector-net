using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Executive system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a54ac906cb7002cc1a30fbb0efadb0a:82""}]")]
    public class SystemExecutiveModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _treatVirtualOnNetCallsAsInternal;

        [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:82")]
        public bool TreatVirtualOnNetCallsAsInternal
        {
            get => _treatVirtualOnNetCallsAsInternal;
            set
            {
                TreatVirtualOnNetCallsAsInternalSpecified = true;
                _treatVirtualOnNetCallsAsInternal = value;
            }
        }

        [XmlIgnore]
        protected bool TreatVirtualOnNetCallsAsInternalSpecified { get; set; }

    }
}
