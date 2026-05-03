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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a54ac906cb7002cc1a30fbb0efadb0a:86""}]")]
    public class SystemExecutiveModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _treatVirtualOnNetCallsAsInternal;

        [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:86")]
        public bool? TreatVirtualOnNetCallsAsInternal
        {
            get => _treatVirtualOnNetCallsAsInternal;
            set
            {
                TreatVirtualOnNetCallsAsInternalSpecified = (value != null);
                _treatVirtualOnNetCallsAsInternal = value;
            }
        }

        [XmlIgnore]
        protected bool TreatVirtualOnNetCallsAsInternalSpecified { get; set; }

        protected bool? _considerExecutiveOnHookForAssistantCalls;

        [XmlElement(ElementName = "considerExecutiveOnHookForAssistantCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:86")]
        public bool? ConsiderExecutiveOnHookForAssistantCalls
        {
            get => _considerExecutiveOnHookForAssistantCalls;
            set
            {
                ConsiderExecutiveOnHookForAssistantCallsSpecified = (value != null);
                _considerExecutiveOnHookForAssistantCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ConsiderExecutiveOnHookForAssistantCallsSpecified { get; set; }

    }
}
