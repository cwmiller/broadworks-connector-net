using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
    /// The response is either a UserBroadWorksAnywhereGetResponse or an ErrorResponse.
    /// Replaced by: UserBroadWorksAnywhereGetRequest16sp2
    /// <see cref="UserBroadWorksAnywhereGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserBroadWorksAnywhereGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16861""}]")]
    public class UserBroadWorksAnywhereGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16861")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

    }
}
