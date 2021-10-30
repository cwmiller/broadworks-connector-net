using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Directed Call Pickup With Barge In.
    /// The response is either a UserDirectedCallPickupWithBargeInGetResponse14sp7 or an
    /// ErrorResponse.
    /// <see cref="UserDirectedCallPickupWithBargeInGetResponse14sp7"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e994db048e7467a66936aa2afd5ac740:44""}]")]
    public class UserDirectedCallPickupWithBargeInGetRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserDirectedCallPickupWithBargeInGetResponse14sp7>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e994db048e7467a66936aa2afd5ac740:44")]
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

    }
}
