using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExecutiveGetRequest.
    /// <see cref="SystemExecutiveGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a54ac906cb7002cc1a30fbb0efadb0a:69""}]")]
    public class SystemExecutiveGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _treatVirtualOnNetCallsAsInternal;

        [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false, Namespace = "")]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:69")]
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

        protected bool _considerExecutiveOnHookForAssistantCalls;

        [XmlElement(ElementName = "considerExecutiveOnHookForAssistantCalls", IsNullable = false, Namespace = "")]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:69")]
        public bool ConsiderExecutiveOnHookForAssistantCalls
        {
            get => _considerExecutiveOnHookForAssistantCalls;
            set
            {
                ConsiderExecutiveOnHookForAssistantCallsSpecified = true;
                _considerExecutiveOnHookForAssistantCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ConsiderExecutiveOnHookForAssistantCallsSpecified { get; set; }

    }
}
