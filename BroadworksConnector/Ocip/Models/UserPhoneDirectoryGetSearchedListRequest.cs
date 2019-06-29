using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a table containing the phone directory for a user.
    /// If the specified user is part of an enterprise, the directory includes all users in the enterprise
    /// and all entries in the enterprise common phone list and the common phone list of the specified user's group.
    /// If the specified user is part of a service provider, the directory includes all users in the user's group
    /// and all entries in the common phone list of the specified user's group.
    /// It is possible to search the directory for names containing a specified search string. The search includes
    /// matches on first name or last name or common phone list names.
    /// The response is either UserPhoneDirectoryGetSearchedListResponse or ErrorResponse.
    /// <see cref="UserPhoneDirectoryGetSearchedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3167""}]")]
    public class UserPhoneDirectoryGetSearchedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3167")]
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
        protected bool UserIdSpecified { get; set; }

        private string _nameSearchString;

        [XmlElement(ElementName = "nameSearchString", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3167")]
        [MinLength(1)]
        public string NameSearchString
        {
            get => _nameSearchString;
            set
            {
                NameSearchStringSpecified = true;
                _nameSearchString = value;
            }
        }

        [XmlIgnore]
        protected bool NameSearchStringSpecified { get; set; }

    }
}
