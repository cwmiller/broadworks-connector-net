using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAnonymousCallRejectionGetRequest.
    /// The response contains the anonymous call rejection system.".
    /// <see cref="SystemAnonymousCallRejectionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b25f8a296bf72b8b383a287bee9127d:60""}]")]
    public class SystemAnonymousCallRejectionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _paiRequired;

        [XmlElement(ElementName = "paiRequired", IsNullable = false, Namespace = "")]
        [Group(@"6b25f8a296bf72b8b383a287bee9127d:60")]
        public bool PaiRequired
        {
            get => _paiRequired;
            set
            {
                PaiRequiredSpecified = true;
                _paiRequired = value;
            }
        }

        [XmlIgnore]
        protected bool PaiRequiredSpecified { get; set; }

        protected bool _screenOnlyLocalCalls;

        [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false, Namespace = "")]
        [Group(@"6b25f8a296bf72b8b383a287bee9127d:60")]
        public bool ScreenOnlyLocalCalls
        {
            get => _screenOnlyLocalCalls;
            set
            {
                ScreenOnlyLocalCallsSpecified = true;
                _screenOnlyLocalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenOnlyLocalCallsSpecified { get; set; }

    }
}
