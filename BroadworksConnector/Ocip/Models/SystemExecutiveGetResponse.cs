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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9a6dbade05624033cf7fe782b7c9a9a7:67""}]")]
    public class SystemExecutiveGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _treatVirtualOnNetCallsAsInternal;

        [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:67")]
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
