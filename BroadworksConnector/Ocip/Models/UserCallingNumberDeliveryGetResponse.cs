using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallingNumberDeliveryGetRequest.
    /// <see cref="UserCallingNumberDeliveryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2739e54a6c7a2ab6abe092f89482573e:58""}]")]
    public class UserCallingNumberDeliveryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActiveForExternalCalls;

        [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"2739e54a6c7a2ab6abe092f89482573e:58")]
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
        [Group(@"2739e54a6c7a2ab6abe092f89482573e:58")]
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
