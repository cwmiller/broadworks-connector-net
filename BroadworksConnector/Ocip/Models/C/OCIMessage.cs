using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// A message contains a list of requests or responses. The server processes all the requests
    /// and returns a message with a corresponding list of responses.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:37"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:38""}]}]")]
    public class OCIMessage<T> where T : OCICommand
    {

        private string _sessionId;

        [XmlElement(ElementName = "sessionId", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:38")]
        public string SessionId
        {
            get => _sessionId;
            set
            {
                SessionIdSpecified = true;
                _sessionId = value;
            }
        }

        [XmlIgnore]
        protected bool SessionIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:38")]
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

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:38")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:38")]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.ExternalUserIdentity _externalUserIdentity;

        [XmlElement(ElementName = "externalUserIdentity", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:38")]
        public BroadWorksConnector.Ocip.Models.C.ExternalUserIdentity ExternalUserIdentity
        {
            get => _externalUserIdentity;
            set
            {
                ExternalUserIdentitySpecified = true;
                _externalUserIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalUserIdentitySpecified { get; set; }

        private string _trackingId;

        [XmlElement(ElementName = "trackingId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:37")]
        [MinLength(1)]
        public string TrackingId
        {
            get => _trackingId;
            set
            {
                TrackingIdSpecified = true;
                _trackingId = value;
            }
        }

        [XmlIgnore]
        protected bool TrackingIdSpecified { get; set; }

        private List<T> _command = new List<T>();

        [XmlElement(ElementName = "command", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:37")]
        public List<T> Command
        {
            get => _command;
            set
            {
                CommandSpecified = true;
                _command = value;
            }
        }

        [XmlIgnore]
        protected bool CommandSpecified { get; set; }

    }
}
