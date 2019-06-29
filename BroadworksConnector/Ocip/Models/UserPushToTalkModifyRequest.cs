using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Change the push to talk service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f32f4b57593f3e1ac6ed1cf45ed62b7c:123""}]")]
    public class UserPushToTalkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f32f4b57593f3e1ac6ed1cf45ed62b7c:123")]
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

        private bool _allowAutoAnswer;

        [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f32f4b57593f3e1ac6ed1cf45ed62b7c:123")]
        public bool AllowAutoAnswer
        {
            get => _allowAutoAnswer;
            set
            {
                AllowAutoAnswerSpecified = true;
                _allowAutoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAutoAnswerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

        [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f32f4b57593f3e1ac6ed1cf45ed62b7c:123")]
        public BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection
        {
            get => _outgoingConnectionSelection;
            set
            {
                OutgoingConnectionSelectionSpecified = true;
                _outgoingConnectionSelection = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingConnectionSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

        [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f32f4b57593f3e1ac6ed1cf45ed62b7c:123")]
        public BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection
        {
            get => _accessListSelection;
            set
            {
                AccessListSelectionSpecified = true;
                _accessListSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AccessListSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _selectedUserIdList;

        [XmlElement(ElementName = "selectedUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f32f4b57593f3e1ac6ed1cf45ed62b7c:123")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SelectedUserIdList
        {
            get => _selectedUserIdList;
            set
            {
                SelectedUserIdListSpecified = true;
                _selectedUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool SelectedUserIdListSpecified { get; set; }

    }
}
