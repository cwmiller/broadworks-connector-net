using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Calling Name Retrieval.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ba51f415ebda0240287c719bc767eadf:165""}]")]
    public class UserCallingNameRetrievalModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ba51f415ebda0240287c719bc767eadf:165")]
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

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:165")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _bypassFiltering;

        [XmlElement(ElementName = "bypassFiltering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:165")]
        public bool BypassFiltering
        {
            get => _bypassFiltering;
            set
            {
                BypassFilteringSpecified = true;
                _bypassFiltering = value;
            }
        }

        [XmlIgnore]
        protected bool BypassFilteringSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallingNameRetrievalWhiteListReplacementList _dnWhiteList;

        [XmlElement(ElementName = "dnWhiteList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:165")]
        public BroadWorksConnector.Ocip.Models.CallingNameRetrievalWhiteListReplacementList DnWhiteList
        {
            get => _dnWhiteList;
            set
            {
                DnWhiteListSpecified = true;
                _dnWhiteList = value;
            }
        }

        [XmlIgnore]
        protected bool DnWhiteListSpecified { get; set; }

    }
}
