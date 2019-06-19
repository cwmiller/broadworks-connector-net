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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:28"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:29""}]}]")]
    public class OCIMessage
    {

        private string _sessionId;

        [XmlElement(ElementName = "sessionId", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:29")]
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
        public bool SessionIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:29")]
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

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:29")]
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
        public bool PhoneNumberSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:29")]
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
        public bool LinePortSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.C.OCICommand> _command = new List<BroadWorksConnector.Ocip.Models.C.OCICommand>();

        [XmlElement(ElementName = "command", IsNullable = false, Namespace = "")]
        [Group(@"77f32f6c8e214eb5c1a80dedfce1cb56:28")]
        public List<BroadWorksConnector.Ocip.Models.C.OCICommand> Command
        {
            get => _command;
            set
            {
                CommandSpecified = true;
                _command = value;
            }
        }

        [XmlIgnore]
        public bool CommandSpecified { get; set; }

    }
}
