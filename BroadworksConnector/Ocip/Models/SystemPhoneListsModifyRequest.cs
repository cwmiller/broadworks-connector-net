using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system phone list settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14831""}]")]
    public class SystemPhoneListsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _allowSpecialNumbersInPhoneLists;

        [XmlElement(ElementName = "allowSpecialNumbersInPhoneLists", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14831")]
        public bool? AllowSpecialNumbersInPhoneLists
        {
            get => _allowSpecialNumbersInPhoneLists;
            set
            {
                AllowSpecialNumbersInPhoneListsSpecified = (value != null);
                _allowSpecialNumbersInPhoneLists = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSpecialNumbersInPhoneListsSpecified { get; set; }

    }
}
