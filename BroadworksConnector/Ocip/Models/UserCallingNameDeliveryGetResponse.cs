using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallingNameDeliveryGetRequest.
    /// <see cref="UserCallingNameDeliveryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8db0221a5f93ea8bb10a92a714b461d3:59""}]")]
    public class UserCallingNameDeliveryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActiveForExternalCalls;

        [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"8db0221a5f93ea8bb10a92a714b461d3:59")]
        public bool IsActiveForExternalCalls
        {
            get => _isActiveForExternalCalls;
            set
            {
                IsActiveForExternalCallsSpecified = true;
                _isActiveForExternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveForExternalCallsSpecified { get; set; }

        private bool _isActiveForInternalCalls;

        [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"8db0221a5f93ea8bb10a92a714b461d3:59")]
        public bool IsActiveForInternalCalls
        {
            get => _isActiveForInternalCalls;
            set
            {
                IsActiveForInternalCallsSpecified = true;
                _isActiveForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveForInternalCallsSpecified { get; set; }

    }
}
