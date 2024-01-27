using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system phone list settings.
    /// The response is either a SuccessResponse or ErrorResponse
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14640""}]")]
    public class SystemPhoneListsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _allowSpecialNumbersInPhoneLists;

        [XmlElement(ElementName = "allowSpecialNumbersInPhoneLists", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14640")]
        public bool AllowSpecialNumbersInPhoneLists
        {
            get => _allowSpecialNumbersInPhoneLists;
            set
            {
                AllowSpecialNumbersInPhoneListsSpecified = true;
                _allowSpecialNumbersInPhoneLists = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSpecialNumbersInPhoneListsSpecified { get; set; }

    }
}
