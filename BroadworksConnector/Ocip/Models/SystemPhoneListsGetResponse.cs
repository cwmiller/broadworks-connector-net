using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemPhoneListsGetRequest.
    /// <see cref="SystemPhoneListsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14624""}]")]
    public class SystemPhoneListsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _allowSpecialNumbersInPhoneLists;

        [XmlElement(ElementName = "allowSpecialNumbersInPhoneLists", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14624")]
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
