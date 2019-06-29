using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a system Anonymous Call Rejection parameter.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b25f8a296bf72b8b383a287bee9127d:77""}]")]
    public class SystemAnonymousCallRejectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _paiRequired;

        [XmlElement(ElementName = "paiRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b25f8a296bf72b8b383a287bee9127d:77")]
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

        private bool _screenOnlyLocalCalls;

        [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b25f8a296bf72b8b383a287bee9127d:77")]
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
